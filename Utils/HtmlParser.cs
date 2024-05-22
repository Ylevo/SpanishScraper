﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace TMOScrapper.Utils
{
    public class HtmlParser
    {
        private static readonly char[] forbiddenPathCharacters = Path.GetInvalidFileNameChars().Union(Path.GetInvalidPathChars()).Union(new char[] { '+' }).ToArray();

        public virtual List<string> ParseScanGroups(HtmlDocument doc)
        {
            var nodes = doc.DocumentNode.SelectNodes(@"//li[contains(concat(' ',normalize-space(@class),' '),' upload-link ')]
                                                                 //div[1][contains(concat(' ',normalize-space(@class),' '),' text-truncate ')]
                                                                 /span");
            List<string> groups = nodes.Select(n => String.Join('+', n.ParentNode.InnerText.Split(',', StringSplitOptions.TrimEntries).Select(g => RemoveForbbidenPathCharacters(g)))).Distinct().ToList();
            groups.Sort();

            return groups;
        }

        public virtual string ParseGroupName(HtmlDocument doc)
        {
            return RemoveForbbidenPathCharacters(doc.DocumentNode.SelectSingleNode("//h1").InnerText);
        }

        public virtual string ParseMangoTitleFromMangoPage(HtmlDocument doc)
        {
            return RemoveForbbidenPathCharacters(doc.DocumentNode.SelectSingleNode("//h2").InnerText);
        }

        public virtual string ParseMangoTitleFromChapterPage(HtmlDocument doc)
        {
            return RemoveForbbidenPathCharacters(doc.DocumentNode.SelectSingleNode("//h1").InnerText);
        }

        public virtual string ParseChapterNumberFromChapterPage(HtmlDocument doc)
        {
            return doc.DocumentNode.SelectSingleNode("//h4").InnerText.Contains("ONE SHOT") ? "000"
                                : "c" + ParseAndPadChapterNumber(doc.DocumentNode.SelectSingleNode("//h2").InnerText.Trim());
        }

        public virtual string ParseGroupNameFromChapterPage(HtmlDocument doc)
        {
            return String.Join('+', doc.DocumentNode.SelectSingleNode("//h2").Elements("a").Select(d => RemoveForbbidenPathCharacters(d.InnerText)).ToArray());
        }

        public virtual List<string> ParseGroupMangos(HtmlDocument doc)
        {
            return doc.DocumentNode.SelectNodes("//div[contains(concat(' ',normalize-space(@class),' '),' proyect-item ')]/a").Select(m => m.Attributes["href"].Value.Trim()).ToList();
        }

        public virtual List<string> ParseChapterImages(HtmlDocument doc)
        {
            return doc.DocumentNode.SelectNodes("//img[contains(concat(' ',normalize-space(@class),' '),' viewer-img ')]").Select(img => img.Attributes["data-src"].Value.Trim()).ToList();
        }

        public virtual SortedDictionary<string, (string, string)[]> ParseChaptersLinks(HtmlDocument doc)
        {
            SortedDictionary<string, (string, string)[]> chapters = new();
            var chaptersNodes = doc.DocumentNode.SelectNodes("//li[contains(concat(' ',normalize-space(@class),' '),' upload-link ')]");
            IEnumerable<HtmlNode> uploadedChaptersNodes;
            string chapterNumber, uploadedChapterLink, groupName;

            for (int i = 0; i < chaptersNodes.Count; ++i)
            {
                chapterNumber = ParseAndPadChapterNumber(chaptersNodes[i].Descendants("a").First().InnerText.Trim());

                uploadedChaptersNodes = chaptersNodes[i].Descendants("li");
                (string, string)[] uploadedChapters = new (string, string)[uploadedChaptersNodes.Count()];

                for (int x = 0; x < uploadedChaptersNodes.Count(); ++x)
                {
                    uploadedChapterLink = uploadedChaptersNodes.ElementAt(x).Descendants("a").Last().Attributes["href"].Value;
                    groupName = String.Join('+', uploadedChaptersNodes.ElementAt(x).Descendants("span").First().InnerText.Split(',', StringSplitOptions.TrimEntries).Select(g => RemoveForbbidenPathCharacters(g)));
                    uploadedChapters[x] = (groupName, uploadedChapterLink);
                }

                if (chapters.ContainsKey(chapterNumber))
                {
                    chapters[chapterNumber] = chapters[chapterNumber].Concat(uploadedChapters).ToArray();
                }
                else
                {
                    chapters.Add(chapterNumber, uploadedChapters);
                }
            }

            return chapters;
        }

        public virtual SortedDictionary<string, (string, string)[]> ParseOneShotLinks(HtmlDocument doc)
        {
            string uploadLink, groupName;
            SortedDictionary<string, (string, string)[]> chapter = new();
            var uploadNodes = doc.DocumentNode.SelectNodes("//li[contains(concat(' ',normalize-space(@class),' '),' upload-link ')]");

            (string, string)[] uploadLinks = new (string, string)[uploadNodes.Count];

            for (int x = 0; x < uploadNodes.Count; ++x)
            {
                uploadLink = uploadNodes.ElementAt(x).Descendants("a").Last().Attributes["href"].Value;
                groupName = String.Join('+', uploadNodes.ElementAt(x).Descendants("span").First().InnerText.Split(',', StringSplitOptions.TrimEntries).Select(g => RemoveForbbidenPathCharacters(g)));
                uploadLinks[x] = (groupName, uploadLink);
            }

            chapter.Add("000", uploadLinks);

            return chapter;
        }

        public virtual string ParseAndPadChapterNumber(string chapterNumber)
        {
            chapterNumber = Regex.Match(chapterNumber, "(?<=Capítulo )(\\d+.\\d+)").Value;
            var splits = chapterNumber.Split('.');
            return splits[0].PadLeft(3, '0') + (int.Parse(splits[1]) > 0 ? ("." + splits[1].Replace("0", "")) : "");
        }

        public virtual string RemoveForbbidenPathCharacters(string filename)
        {
            // Split the string using forbidden characters to remove them, join them with a space as delimiter, truncate to 40, trim and remove excessive spaces
            return Regex.Replace(string.Join(" ", WebUtility.HtmlDecode(filename).Split(forbiddenPathCharacters)).Truncate(40).Trim(new char[] { ' ', '.' }), @"\s+", " ");
        }
    }

    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}