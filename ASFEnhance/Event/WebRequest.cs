﻿using AngleSharp.Dom;
using ArchiSteamFarm.Steam;
using ArchiSteamFarm.Steam.Integration;
using ArchiSteamFarm.Web.Responses;
using System.Text.RegularExpressions;
using static ASFEnhance.Utils;

namespace ASFEnhance.Event
{
    internal static partial class WebRequest
    {
        [GeneratedRegex("\"CLANACCOUNTID\":(\\d+),")]
        private static partial Regex MatchClanaCCountId();

        /// <summary>
        /// 模拟做题
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="clan_accountid"></param>
        /// <param name="door_index"></param>
        /// <returns></returns>
        internal static async Task DoEventTask(Bot bot, string clan_accountid, uint door_index)
        {
            Uri request = new(SteamStoreURL, "/saleaction/ajaxopendoor");

            Dictionary<string, string> data = new(3) {
                {"door_index", door_index.ToString()},
                {"clan_accountid", clan_accountid},
            };

            _ = await bot.ArchiWebHandler.UrlPostWithSession(request, data: data).ConfigureAwait(false);
        }

        /// <summary>
        /// 获取Token
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="salePage"></param>
        /// <returns></returns>
        internal static async Task<string?> FetchEventToken(Bot bot, string salePage)
        {
            Uri request = new(SteamStoreURL, $"/sale/{salePage}");

            var response = await bot.ArchiWebHandler.UrlGetToHtmlDocumentWithSession(request).ConfigureAwait(false);

            if (response == null)
            {
                return null;
            }

            var configEle = response?.Content?.QuerySelector<IElement>("#application_config");
            string community = configEle?.GetAttribute("data-community") ?? "";
            var match = MatchClanaCCountId().Match(community);

            return match.Success ? match.Groups[1].Value : null;
        }
    }
}
