﻿#region License
// Copyright (c) 2005-2012, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

#region Usings...
#endregion

namespace ZoneEngine
{
    public class XPTable
    {
        #region RK XP
        public double[,] tableRKXP =
            {
                { 1, 0, 1450 }, { 2, 1450, 2600 }, { 3, 4050, 3100 }, { 4, 7150, 4000 },
                { 5, 11150, 4500 }, { 6, 15650, 5000 }, { 7, 20650, 5500 }, { 8, 26150, 6000 }, { 9, 32150, 6500 },
                { 10, 38650, 7000 }, { 11, 45650, 7700 }, { 12, 53350, 8300 }, { 13, 61650, 8900 }, { 14, 70550, 9600 },
                { 15, 80150, 10400 }, { 16, 90550, 11000 }, { 17, 101550, 11900 }, { 18, 113450, 12700 },
                { 19, 126150, 13700 }, { 20, 139850, 15400 }, { 21, 155250, 16400 }, { 22, 171650, 17600 },
                { 23, 189250, 18800 }, { 24, 208050, 20100 }, { 25, 228150, 21500 }, { 26, 249650, 22900 },
                { 27, 272550, 24500 }, { 28, 297050, 26100 }, { 29, 323150, 27800 }, { 30, 350950, 30900 },
                { 31, 381850, 33000 }, { 32, 414850, 35100 }, { 33, 449950, 37400 }, { 34, 487350, 39900 },
                { 35, 527250, 42400 }, { 36, 569650, 45100 }, { 37, 614750, 47900 }, { 38, 662650, 50900 },
                { 39, 713550, 54000 }, { 40, 767550, 57400 }, { 41, 824950, 60900 }, { 42, 885850, 64500 },
                { 43, 950350, 68400 }, { 44, 1018750, 76400 }, { 45, 1095150, 81000 }, { 46, 1176150, 85900 },
                { 47, 1262050, 91000 }, { 48, 1353050, 96400 }, { 49, 1449450, 101900 }, { 50, 1551350, 108000 },
                { 51, 1659350, 114300 }, { 52, 1773650, 120800 }, { 53, 1894450, 127700 }, { 54, 2022150, 135000 },
                { 55, 2157150, 142600 }, { 56, 2299750, 150700 }, { 57, 2450450, 159100 }, { 58, 2609550, 167800 },
                { 59, 2777350, 177100 }, { 60, 2954450, 203500 }, { 61, 3157950, 214700 }, { 62, 3372650, 226700 },
                { 63, 3599350, 239100 }, { 64, 3838450, 251900 }, { 65, 4090350, 265700 }, { 66, 4356050, 280000 },
                { 67, 4636050, 294800 }, { 68, 4930850, 310600 }, { 69, 5241450, 327000 }, { 70, 5568450, 344400 },
                { 71, 5912850, 362300 }, { 72, 6275150, 381100 }, { 73, 6656250, 401000 }, { 74, 7057250, 421600 },
                { 75, 7478850, 443300 }, { 76, 7922150, 508100 }, { 77, 8430250, 534200 }, { 78, 8964450, 561600 },
                { 79, 9526050, 590200 }, { 80, 10116250, 620000 }, { 81, 10736250, 651000 }, { 82, 11387250, 683700 },
                { 83, 12070950, 717900 }, { 84, 12788850, 753500 }, { 85, 13542350, 790800 }, { 86, 14333150, 829400 },
                { 87, 15162550, 870000 }, { 88, 16032550, 912600 }, { 89, 16945150, 956800 }, { 90, 17901950, 1003000 },
                { 91, 18904950, 1051300 }, { 92, 19956250, 1101500 }, { 93, 21057750, 1153900 }, { 94, 22211650, 1208800 },
                { 95, 23420450, 1266000 }, { 96, 24686450, 1325500 }, { 97, 26011950, 1387700 }, { 98, 27399650, 1452300 },
                { 99, 28851950, 1519900 }, { 100, 30371850, 1590300 }, { 101, 31962150, 1663500 },
                { 102, 33625650, 1739900 }, { 103, 35365550, 1819600 }, { 104, 37185150, 1902200 },
                { 105, 39087350, 1988900 }, { 106, 41076250, 2078600 }, { 107, 43154850, 2172100 },
                { 108, 45326950, 2269800 }, { 109, 47596750, 2371100 }, { 110, 49967850, 2476600 },
                { 111, 52444450, 2586600 }, { 112, 55031050, 2701000 }, { 113, 57732050, 2819800 },
                { 114, 60551850, 2943600 }, { 115, 63495450, 3072400 }, { 116, 66567850, 3205800 },
                { 117, 69773650, 3345200 }, { 118, 73118850, 3489700 }, { 119, 76608550, 3640200 },
                { 120, 80248750, 3796500 }, { 121, 84045250, 3958900 }, { 122, 88004150, 4128000 },
                { 123, 92132150, 4303400 }, { 124, 96435550, 4485700 }, { 125, 100921250, 4674800 },
                { 126, 105596050, 4871700 }, { 127, 110467750, 5075700 }, { 128, 115543450, 5288100 },
                { 129, 120831550, 5508200 }, { 130, 126339750, 5736800 }, { 131, 132076550, 5974600 },
                { 132, 138051150, 6220700 }, { 133, 144271850, 6476500 }, { 134, 150748350, 6742200 },
                { 135, 157490550, 7017500 }, { 136, 164508050, 7303700 }, { 137, 171811750, 7600100 },
                { 138, 179411850, 7907600 }, { 139, 187319450, 8227000 }, { 140, 195546450, 8557700 },
                { 141, 204104150, 8901000 }, { 142, 213005150, 9256800 }, { 143, 222261950, 9625800 },
                { 144, 231887750, 10008600 }, { 145, 241896350, 10405300 }, { 146, 252301650, 10816600 },
                { 147, 263118250, 11242500 }, { 148, 274360750, 11684300 }, { 149, 286045050, 12141900 },
                { 150, 298186950, 12616200 }, { 151, 310803150, 13107200 }, { 152, 323910350, 13816100 },
                { 153, 337726450, 14143600 }, { 154, 351870050, 14689700 }, { 155, 366559750, 15255300 },
                { 156, 381815050, 15841000 }, { 157, 397656050, 16447900 }, { 158, 414103950, 17075800 },
                { 159, 431179750, 17725900 }, { 160, 448905650, 18399400 }, { 161, 467305050, 19096100 },
                { 162, 486401150, 19817500 }, { 163, 506218650, 20564100 }, { 164, 526782750, 21336600 },
                { 165, 548119350, 2213610 }, { 166, 570255450, 22963600 }, { 167, 593219050, 23819700 },
                { 168, 617038750, 24705200 }, { 169, 641743950, 25621100 }, { 170, 667365050, 26569000 },
                { 171, 693934050, 27548800 }, { 172, 721482850, 28562900 }, { 173, 750045750, 29611100 },
                { 174, 779656850, 30695300 }, { 175, 810352150, 31816300 }, { 176, 842168450, 32975100 },
                { 177, 875143550, 34173500 }, { 178, 909317050, 35412500 }, { 179, 944729550, 36692500 },
                { 180, 981422050, 38016500 }, { 181, 1019438550, 39384400 }, { 182, 1058822950, 40797700 },
                { 183, 1099620650, 42258500 }, { 184, 1141879150, 43768300 }, { 185, 1185647450, 45328100 },
                { 186, 1230975550, 46939900 }, { 187, 1277915450, 48604900 }, { 188, 1326520350, 50324600 },
                { 189, 1376844950, 52101200 }, { 190, 1428946150, 53936300 }, { 191, 1482882450, 55831600 },
                { 192, 1538714050, 57788700 }, { 193, 1596502750, 59810000 }, { 194, 1656312750, 61897000 },
                { 195, 1718209750, 64052200 }, { 196, 1782261950, 66277200 }, { 197, 1848539150, 68574400 },
                { 198, 1917113550, 70945700 }, { 199, 1988059250, 73393900 }, { 200, 2061453150, 75920900 },
            };
        #endregion

        #region SL XP
        public int[,] tableSLSK =
            {
                { 200, 0, 80000 }, { 201, 80000, 96000 }, { 202, 176000, 115200 },
                { 203, 291200, 138240 }, { 204, 429440, 165888 }, { 205, 595328, 199066 }, { 206, 794394, 238879 },
                { 207, 1033273, 286654 }, { 208, 1319927, 343985 }, { 209, 1663912, 412782 }, { 210, 2076694, 495339 },
                { 211, 2572033, 594407 }, { 212, 3166440, 713288 }, { 213, 3879728, 855946 }, { 214, 4735674, 1027135 },
                { 215, 5762809, 1232562 }, { 216, 6995371, 1479074 }, { 217, 8474445, 1774889 }, { 218, 10249334, 2129867 },
                { 219, 12379201, 2555840 }, { 220, 14935041, 0 },
            };
        #endregion

        #region AI XP
        public double[,] tableAIXP =
            {
                { 01, 1500, 1500 }, { 02, 10500, 9000 }, { 03, 33000, 22500 },
                { 04, 75000, 42000 }, { 05, 142500, 67500 }, { 06, 241500, 99000 }, { 07, 378000, 136500 },
                { 08, 558000, 180000 }, { 09, 787500, 229500 }, { 10, 1072500, 285000 }, { 11, 1419000, 346500 },
                { 12, 1833000, 414000 }, { 13, 2320500, 487500 }, { 14, 2887500, 567000 }, { 15, 3566910, 697410 },
                { 16, 4442724, 857814 }, { 17, 5497836, 1055112 }, { 18, 6795623, 1297787 }, { 19, 8391901, 1596278 },
                { 20, 10323398, 1931497 }, { 21, 12621879, 2298481 }, { 22, 15311102, 2689223 }, { 23, 18403708, 3092606 },
                { 24, 21898353, 3494645 }, { 25, 25777409, 3879056 }, { 26, 30005580, 4228171 }, { 27, 34614287, 4608707 },
                { 28, 39637777, 5023490 }, { 29, 45113381, 5475604 }, { 30, 51081790, 5968409 }, { 31, 0, 0 }
            };
        #endregion
    }
}