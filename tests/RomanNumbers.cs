﻿using Basic.Katas;
using NUnit.Framework;

namespace Basic.Katas.Tests
{
    [TestFixture]
    class RomanNumbersTests
    {
        [TestCase(1U,"I")]
        [TestCase(2U,"II")]
        [TestCase(3U,"III")]
        [TestCase(4U,"IV")]
        [TestCase(5U,"V")]
        [TestCase(6U,"VI")]
        [TestCase(7U,"VII")]
        [TestCase(8U,"VIII")]
        [TestCase(9U,"IX")]
        [TestCase(10U,"X")]
        [TestCase(11U,"XI")]
        [TestCase(12U,"XII")]
        [TestCase(13U,"XIII")]
        [TestCase(14U,"XIV")]
        [TestCase(15U,"XV")]
        [TestCase(16U,"XVI")]
        [TestCase(17U,"XVII")]
        [TestCase(18U,"XVIII")]
        [TestCase(19U,"XIX")]
        [TestCase(20U,"XX")]
        [TestCase(21U,"XXI")]
        [TestCase(22U,"XXII")]
        [TestCase(23U,"XXIII")]
        [TestCase(24U,"XXIV")]
        [TestCase(25U,"XXV")]
        [TestCase(26U,"XXVI")]
        [TestCase(27U,"XXVII")]
        [TestCase(28U,"XXVIII")]
        [TestCase(29U,"XXIX")]
        [TestCase(30U,"XXX")]
        [TestCase(31U,"XXXI")]
        [TestCase(32U,"XXXII")]
        [TestCase(33U,"XXXIII")]
        [TestCase(34U,"XXXIV")]
        [TestCase(35U,"XXXV")]
        [TestCase(36U,"XXXVI")]
        [TestCase(37U,"XXXVII")]
        [TestCase(38U,"XXXVIII")]
        [TestCase(39U,"XXXIX")]
        [TestCase(40U,"XL")]
        [TestCase(41U,"XLI")]
        [TestCase(42U,"XLII")]
        [TestCase(43U,"XLIII")]
        [TestCase(44U,"XLIV")]
        [TestCase(45U,"XLV")]
        [TestCase(46U,"XLVI")]
        [TestCase(47U,"XLVII")]
        [TestCase(48U,"XLVIII")]
        [TestCase(49U,"XLIX")]
        [TestCase(50U,"L")]
        [TestCase(51U,"LI")]
        [TestCase(52U,"LII")]
        [TestCase(53U,"LIII")]
        [TestCase(54U,"LIV")]
        [TestCase(55U,"LV")]
        [TestCase(56U,"LVI")]
        [TestCase(57U,"LVII")]
        [TestCase(58U,"LVIII")]
        [TestCase(59U,"LIX")]
        [TestCase(60U,"LX")]
        [TestCase(61U,"LXI")]
        [TestCase(62U,"LXII")]
        [TestCase(63U,"LXIII")]
        [TestCase(64U,"LXIV")]
        [TestCase(65U,"LXV")]
        [TestCase(66U,"LXVI")]
        [TestCase(67U,"LXVII")]
        [TestCase(68U,"LXVIII")]
        [TestCase(69U,"LXIX")]
        [TestCase(70U,"LXX")]
        [TestCase(71U,"LXXI")]
        [TestCase(72U,"LXXII")]
        [TestCase(73U,"LXXIII")]
        [TestCase(74U,"LXXIV")]
        [TestCase(75U,"LXXV")]
        [TestCase(76U,"LXXVI")]
        [TestCase(77U,"LXXVII")]
        [TestCase(78U,"LXXVIII")]
        [TestCase(79U,"LXXIX")]
        [TestCase(80U,"LXXX")]
        [TestCase(81U,"LXXXI")]
        [TestCase(82U,"LXXXII")]
        [TestCase(83U,"LXXXIII")]
        [TestCase(84U,"LXXXIV")]
        [TestCase(85U,"LXXXV")]
        [TestCase(86U,"LXXXVI")]
        [TestCase(87U,"LXXXVII")]
        [TestCase(88U,"LXXXVIII")]
        [TestCase(89U,"LXXXIX")]
        [TestCase(90U,"XC")]
        [TestCase(91U,"XCI")]
        [TestCase(92U,"XCII")]
        [TestCase(93U,"XCIII")]
        [TestCase(94U,"XCIV")]
        [TestCase(95U,"XCV")]
        [TestCase(96U,"XCVI")]
        [TestCase(97U,"XCVII")]
        [TestCase(98U,"XCVIII")]
        [TestCase(99U,"XCIX")]
        [TestCase(100U,"C")]
        [TestCase(101U,"CI")]
        [TestCase(102U,"CII")]
        [TestCase(103U,"CIII")]
        [TestCase(104U,"CIV")]
        [TestCase(105U,"CV")]
        [TestCase(106U,"CVI")]
        [TestCase(107U,"CVII")]
        [TestCase(108U,"CVIII")]
        [TestCase(109U,"CIX")]
        [TestCase(110U,"CX")]
        [TestCase(111U,"CXI")]
        [TestCase(112U,"CXII")]
        [TestCase(113U,"CXIII")]
        [TestCase(114U,"CXIV")]
        [TestCase(115U,"CXV")]
        [TestCase(116U,"CXVI")]
        [TestCase(117U,"CXVII")]
        [TestCase(118U,"CXVIII")]
        [TestCase(119U,"CXIX")]
        [TestCase(120U,"CXX")]
        [TestCase(121U,"CXXI")]
        [TestCase(122U,"CXXII")]
        [TestCase(123U,"CXXIII")]
        [TestCase(124U,"CXXIV")]
        [TestCase(125U,"CXXV")]
        [TestCase(126U,"CXXVI")]
        [TestCase(127U,"CXXVII")]
        [TestCase(128U,"CXXVIII")]
        [TestCase(129U,"CXXIX")]
        [TestCase(130U,"CXXX")]
        [TestCase(131U,"CXXXI")]
        [TestCase(132U,"CXXXII")]
        [TestCase(133U,"CXXXIII")]
        [TestCase(134U,"CXXXIV")]
        [TestCase(135U,"CXXXV")]
        [TestCase(136U,"CXXXVI")]
        [TestCase(137U,"CXXXVII")]
        [TestCase(138U,"CXXXVIII")]
        [TestCase(139U,"CXXXIX")]
        [TestCase(140U,"CXL")]
        [TestCase(141U,"CXLI")]
        [TestCase(142U,"CXLII")]
        [TestCase(143U,"CXLIII")]
        [TestCase(144U,"CXLIV")]
        [TestCase(145U,"CXLV")]
        [TestCase(146U,"CXLVI")]
        [TestCase(147U,"CXLVII")]
        [TestCase(148U,"CXLVIII")]
        [TestCase(149U,"CXLIX")]
        [TestCase(150U,"CL")]
        [TestCase(151U,"CLI")]
        [TestCase(152U,"CLII")]
        [TestCase(153U,"CLIII")]
        [TestCase(154U,"CLIV")]
        [TestCase(155U,"CLV")]
        [TestCase(156U,"CLVI")]
        [TestCase(157U,"CLVII")]
        [TestCase(158U,"CLVIII")]
        [TestCase(159U,"CLIX")]
        [TestCase(160U,"CLX")]
        [TestCase(161U,"CLXI")]
        [TestCase(162U,"CLXII")]
        [TestCase(163U,"CLXIII")]
        [TestCase(164U,"CLXIV")]
        [TestCase(165U,"CLXV")]
        [TestCase(166U,"CLXVI")]
        [TestCase(167U,"CLXVII")]
        [TestCase(168U,"CLXVIII")]
        [TestCase(169U,"CLXIX")]
        [TestCase(170U,"CLXX")]
        [TestCase(171U,"CLXXI")]
        [TestCase(172U,"CLXXII")]
        [TestCase(173U,"CLXXIII")]
        [TestCase(174U,"CLXXIV")]
        [TestCase(175U,"CLXXV")]
        [TestCase(176U,"CLXXVI")]
        [TestCase(177U,"CLXXVII")]
        [TestCase(178U,"CLXXVIII")]
        [TestCase(179U,"CLXXIX")]
        [TestCase(180U,"CLXXX")]
        [TestCase(181U,"CLXXXI")]
        [TestCase(182U,"CLXXXII")]
        [TestCase(183U,"CLXXXIII")]
        [TestCase(184U,"CLXXXIV")]
        [TestCase(185U,"CLXXXV")]
        [TestCase(186U,"CLXXXVI")]
        [TestCase(187U,"CLXXXVII")]
        [TestCase(188U,"CLXXXVIII")]
        [TestCase(189U,"CLXXXIX")]
        [TestCase(190U,"CXC")]
        [TestCase(191U,"CXCI")]
        [TestCase(192U,"CXCII")]
        [TestCase(193U,"CXCIII")]
        [TestCase(194U,"CXCIV")]
        [TestCase(195U,"CXCV")]
        [TestCase(196U,"CXCVI")]
        [TestCase(197U,"CXCVII")]
        [TestCase(198U,"CXCVIII")]
        [TestCase(199U,"CXCIX")]
        [TestCase(200U,"CC")]
        [TestCase(201U,"CCI")]
        [TestCase(202U,"CCII")]
        [TestCase(203U,"CCIII")]
        [TestCase(204U,"CCIV")]
        [TestCase(205U,"CCV")]
        [TestCase(206U,"CCVI")]
        [TestCase(207U,"CCVII")]
        [TestCase(208U,"CCVIII")]
        [TestCase(209U,"CCIX")]
        [TestCase(210U,"CCX")]
        [TestCase(211U,"CCXI")]
        [TestCase(212U,"CCXII")]
        [TestCase(213U,"CCXIII")]
        [TestCase(214U,"CCXIV")]
        [TestCase(215U,"CCXV")]
        [TestCase(216U,"CCXVI")]
        [TestCase(217U,"CCXVII")]
        [TestCase(218U,"CCXVIII")]
        [TestCase(219U,"CCXIX")]
        [TestCase(220U,"CCXX")]
        [TestCase(221U,"CCXXI")]
        [TestCase(222U,"CCXXII")]
        [TestCase(223U,"CCXXIII")]
        [TestCase(224U,"CCXXIV")]
        [TestCase(225U,"CCXXV")]
        [TestCase(226U,"CCXXVI")]
        [TestCase(227U,"CCXXVII")]
        [TestCase(228U,"CCXXVIII")]
        [TestCase(229U,"CCXXIX")]
        [TestCase(230U,"CCXXX")]
        [TestCase(231U,"CCXXXI")]
        [TestCase(232U,"CCXXXII")]
        [TestCase(233U,"CCXXXIII")]
        [TestCase(234U,"CCXXXIV")]
        [TestCase(235U,"CCXXXV")]
        [TestCase(236U,"CCXXXVI")]
        [TestCase(237U,"CCXXXVII")]
        [TestCase(238U,"CCXXXVIII")]
        [TestCase(239U,"CCXXXIX")]
        [TestCase(240U,"CCXL")]
        [TestCase(241U,"CCXLI")]
        [TestCase(242U,"CCXLII")]
        [TestCase(243U,"CCXLIII")]
        [TestCase(244U,"CCXLIV")]
        [TestCase(245U,"CCXLV")]
        [TestCase(246U,"CCXLVI")]
        [TestCase(247U,"CCXLVII")]
        [TestCase(248U,"CCXLVIII")]
        [TestCase(249U,"CCXLIX")]
        [TestCase(250U,"CCL")]
        [TestCase(251U,"CCLI")]
        [TestCase(252U,"CCLII")]
        [TestCase(253U,"CCLIII")]
        [TestCase(254U,"CCLIV")]
        [TestCase(255U,"CCLV")]
        [TestCase(256U,"CCLVI")]
        [TestCase(257U,"CCLVII")]
        [TestCase(258U,"CCLVIII")]
        [TestCase(259U,"CCLIX")]
        [TestCase(260U,"CCLX")]
        [TestCase(261U,"CCLXI")]
        [TestCase(262U,"CCLXII")]
        [TestCase(263U,"CCLXIII")]
        [TestCase(264U,"CCLXIV")]
        [TestCase(265U,"CCLXV")]
        [TestCase(266U,"CCLXVI")]
        [TestCase(267U,"CCLXVII")]
        [TestCase(268U,"CCLXVIII")]
        [TestCase(269U,"CCLXIX")]
        [TestCase(270U,"CCLXX")]
        [TestCase(271U,"CCLXXI")]
        [TestCase(272U,"CCLXXII")]
        [TestCase(273U,"CCLXXIII")]
        [TestCase(274U,"CCLXXIV")]
        [TestCase(275U,"CCLXXV")]
        [TestCase(276U,"CCLXXVI")]
        [TestCase(277U,"CCLXXVII")]
        [TestCase(278U,"CCLXXVIII")]
        [TestCase(279U,"CCLXXIX")]
        [TestCase(280U,"CCLXXX")]
        [TestCase(281U,"CCLXXXI")]
        [TestCase(282U,"CCLXXXII")]
        [TestCase(283U,"CCLXXXIII")]
        [TestCase(284U,"CCLXXXIV")]
        [TestCase(285U,"CCLXXXV")]
        [TestCase(286U,"CCLXXXVI")]
        [TestCase(287U,"CCLXXXVII")]
        [TestCase(288U,"CCLXXXVIII")]
        [TestCase(289U,"CCLXXXIX")]
        [TestCase(290U,"CCXC")]
        [TestCase(291U,"CCXCI")]
        [TestCase(292U,"CCXCII")]
        [TestCase(293U,"CCXCIII")]
        [TestCase(294U,"CCXCIV")]
        [TestCase(295U,"CCXCV")]
        [TestCase(296U,"CCXCVI")]
        [TestCase(297U,"CCXCVII")]
        [TestCase(298U,"CCXCVIII")]
        [TestCase(299U,"CCXCIX")]
        [TestCase(300U,"CCC")]
        [TestCase(301U,"CCCI")]
        [TestCase(302U,"CCCII")]
        [TestCase(303U,"CCCIII")]
        [TestCase(304U,"CCCIV")]
        [TestCase(305U,"CCCV")]
        [TestCase(306U,"CCCVI")]
        [TestCase(307U,"CCCVII")]
        [TestCase(308U,"CCCVIII")]
        [TestCase(309U,"CCCIX")]
        [TestCase(310U,"CCCX")]
        [TestCase(311U,"CCCXI")]
        [TestCase(312U,"CCCXII")]
        [TestCase(313U,"CCCXIII")]
        [TestCase(314U,"CCCXIV")]
        [TestCase(315U,"CCCXV")]
        [TestCase(316U,"CCCXVI")]
        [TestCase(317U,"CCCXVII")]
        [TestCase(318U,"CCCXVIII")]
        [TestCase(319U,"CCCXIX")]
        [TestCase(320U,"CCCXX")]
        [TestCase(321U,"CCCXXI")]
        [TestCase(322U,"CCCXXII")]
        [TestCase(323U,"CCCXXIII")]
        [TestCase(324U,"CCCXXIV")]
        [TestCase(325U,"CCCXXV")]
        [TestCase(326U,"CCCXXVI")]
        [TestCase(327U,"CCCXXVII")]
        [TestCase(328U,"CCCXXVIII")]
        [TestCase(329U,"CCCXXIX")]
        [TestCase(330U,"CCCXXX")]
        [TestCase(331U,"CCCXXXI")]
        [TestCase(332U,"CCCXXXII")]
        [TestCase(333U,"CCCXXXIII")]
        [TestCase(334U,"CCCXXXIV")]
        [TestCase(335U,"CCCXXXV")]
        [TestCase(336U,"CCCXXXVI")]
        [TestCase(337U,"CCCXXXVII")]
        [TestCase(338U,"CCCXXXVIII")]
        [TestCase(339U,"CCCXXXIX")]
        [TestCase(340U,"CCCXL")]
        [TestCase(341U,"CCCXLI")]
        [TestCase(342U,"CCCXLII")]
        [TestCase(343U,"CCCXLIII")]
        [TestCase(344U,"CCCXLIV")]
        [TestCase(345U,"CCCXLV")]
        [TestCase(346U,"CCCXLVI")]
        [TestCase(347U,"CCCXLVII")]
        [TestCase(348U,"CCCXLVIII")]
        [TestCase(349U,"CCCXLIX")]
        [TestCase(350U,"CCCL")]
        [TestCase(351U,"CCCLI")]
        [TestCase(352U,"CCCLII")]
        [TestCase(353U,"CCCLIII")]
        [TestCase(354U,"CCCLIV")]
        [TestCase(355U,"CCCLV")]
        [TestCase(356U,"CCCLVI")]
        [TestCase(357U,"CCCLVII")]
        [TestCase(358U,"CCCLVIII")]
        [TestCase(359U,"CCCLIX")]
        [TestCase(360U,"CCCLX")]
        [TestCase(361U,"CCCLXI")]
        [TestCase(362U,"CCCLXII")]
        [TestCase(363U,"CCCLXIII")]
        [TestCase(364U,"CCCLXIV")]
        [TestCase(365U,"CCCLXV")]
        [TestCase(366U,"CCCLXVI")]
        [TestCase(367U,"CCCLXVII")]
        [TestCase(368U,"CCCLXVIII")]
        [TestCase(369U,"CCCLXIX")]
        [TestCase(370U,"CCCLXX")]
        [TestCase(371U,"CCCLXXI")]
        [TestCase(372U,"CCCLXXII")]
        [TestCase(373U,"CCCLXXIII")]
        [TestCase(374U,"CCCLXXIV")]
        [TestCase(375U,"CCCLXXV")]
        [TestCase(376U,"CCCLXXVI")]
        [TestCase(377U,"CCCLXXVII")]
        [TestCase(378U,"CCCLXXVIII")]
        [TestCase(379U,"CCCLXXIX")]
        [TestCase(380U,"CCCLXXX")]
        [TestCase(381U,"CCCLXXXI")]
        [TestCase(382U,"CCCLXXXII")]
        [TestCase(383U,"CCCLXXXIII")]
        [TestCase(384U,"CCCLXXXIV")]
        [TestCase(385U,"CCCLXXXV")]
        [TestCase(386U,"CCCLXXXVI")]
        [TestCase(387U,"CCCLXXXVII")]
        [TestCase(388U,"CCCLXXXVIII")]
        [TestCase(389U,"CCCLXXXIX")]
        [TestCase(390U,"CCCXC")]
        [TestCase(391U,"CCCXCI")]
        [TestCase(392U,"CCCXCII")]
        [TestCase(393U,"CCCXCIII")]
        [TestCase(394U,"CCCXCIV")]
        [TestCase(395U,"CCCXCV")]
        [TestCase(396U,"CCCXCVI")]
        [TestCase(397U,"CCCXCVII")]
        [TestCase(398U,"CCCXCVIII")]
        [TestCase(399U,"CCCXCIX")]
        [TestCase(400U,"CD")]
        [TestCase(401U,"CDI")]
        [TestCase(402U,"CDII")]
        [TestCase(403U,"CDIII")]
        [TestCase(404U,"CDIV")]
        [TestCase(405U,"CDV")]
        [TestCase(406U,"CDVI")]
        [TestCase(407U,"CDVII")]
        [TestCase(408U,"CDVIII")]
        [TestCase(409U,"CDIX")]
        [TestCase(410U,"CDX")]
        [TestCase(411U,"CDXI")]
        [TestCase(412U,"CDXII")]
        [TestCase(413U,"CDXIII")]
        [TestCase(414U,"CDXIV")]
        [TestCase(415U,"CDXV")]
        [TestCase(416U,"CDXVI")]
        [TestCase(417U,"CDXVII")]
        [TestCase(418U,"CDXVIII")]
        [TestCase(419U,"CDXIX")]
        [TestCase(420U,"CDXX")]
        [TestCase(421U,"CDXXI")]
        [TestCase(422U,"CDXXII")]
        [TestCase(423U,"CDXXIII")]
        [TestCase(424U,"CDXXIV")]
        [TestCase(425U,"CDXXV")]
        [TestCase(426U,"CDXXVI")]
        [TestCase(427U,"CDXXVII")]
        [TestCase(428U,"CDXXVIII")]
        [TestCase(429U,"CDXXIX")]
        [TestCase(430U,"CDXXX")]
        [TestCase(431U,"CDXXXI")]
        [TestCase(432U,"CDXXXII")]
        [TestCase(433U,"CDXXXIII")]
        [TestCase(434U,"CDXXXIV")]
        [TestCase(435U,"CDXXXV")]
        [TestCase(436U,"CDXXXVI")]
        [TestCase(437U,"CDXXXVII")]
        [TestCase(438U,"CDXXXVIII")]
        [TestCase(439U,"CDXXXIX")]
        [TestCase(440U,"CDXL")]
        [TestCase(441U,"CDXLI")]
        [TestCase(442U,"CDXLII")]
        [TestCase(443U,"CDXLIII")]
        [TestCase(444U,"CDXLIV")]
        [TestCase(445U,"CDXLV")]
        [TestCase(446U,"CDXLVI")]
        [TestCase(447U,"CDXLVII")]
        [TestCase(448U,"CDXLVIII")]
        [TestCase(449U,"CDXLIX")]
        [TestCase(450U,"CDL")]
        [TestCase(451U,"CDLI")]
        [TestCase(452U,"CDLII")]
        [TestCase(453U,"CDLIII")]
        [TestCase(454U,"CDLIV")]
        [TestCase(455U,"CDLV")]
        [TestCase(456U,"CDLVI")]
        [TestCase(457U,"CDLVII")]
        [TestCase(458U,"CDLVIII")]
        [TestCase(459U,"CDLIX")]
        [TestCase(460U,"CDLX")]
        [TestCase(461U,"CDLXI")]
        [TestCase(462U,"CDLXII")]
        [TestCase(463U,"CDLXIII")]
        [TestCase(464U,"CDLXIV")]
        [TestCase(465U,"CDLXV")]
        [TestCase(466U,"CDLXVI")]
        [TestCase(467U,"CDLXVII")]
        [TestCase(468U,"CDLXVIII")]
        [TestCase(469U,"CDLXIX")]
        [TestCase(470U,"CDLXX")]
        [TestCase(471U,"CDLXXI")]
        [TestCase(472U,"CDLXXII")]
        [TestCase(473U,"CDLXXIII")]
        [TestCase(474U,"CDLXXIV")]
        [TestCase(475U,"CDLXXV")]
        [TestCase(476U,"CDLXXVI")]
        [TestCase(477U,"CDLXXVII")]
        [TestCase(478U,"CDLXXVIII")]
        [TestCase(479U,"CDLXXIX")]
        [TestCase(480U,"CDLXXX")]
        [TestCase(481U,"CDLXXXI")]
        [TestCase(482U,"CDLXXXII")]
        [TestCase(483U,"CDLXXXIII")]
        [TestCase(484U,"CDLXXXIV")]
        [TestCase(485U,"CDLXXXV")]
        [TestCase(486U,"CDLXXXVI")]
        [TestCase(487U,"CDLXXXVII")]
        [TestCase(488U,"CDLXXXVIII")]
        [TestCase(489U,"CDLXXXIX")]
        [TestCase(490U,"CDXC")]
        [TestCase(491U,"CDXCI")]
        [TestCase(492U,"CDXCII")]
        [TestCase(493U,"CDXCIII")]
        [TestCase(494U,"CDXCIV")]
        [TestCase(495U,"CDXCV")]
        [TestCase(496U,"CDXCVI")]
        [TestCase(497U,"CDXCVII")]
        [TestCase(498U,"CDXCVIII")]
        [TestCase(499U,"CDXCIX")]
        [TestCase(500U,"D")]
        [TestCase(501U,"DI")]
        [TestCase(502U,"DII")]
        [TestCase(503U,"DIII")]
        [TestCase(504U,"DIV")]
        [TestCase(505U,"DV")]
        [TestCase(506U,"DVI")]
        [TestCase(507U,"DVII")]
        [TestCase(508U,"DVIII")]
        [TestCase(509U,"DIX")]
        [TestCase(510U,"DX")]
        [TestCase(511U,"DXI")]
        [TestCase(512U,"DXII")]
        [TestCase(513U,"DXIII")]
        [TestCase(514U,"DXIV")]
        [TestCase(515U,"DXV")]
        [TestCase(516U,"DXVI")]
        [TestCase(517U,"DXVII")]
        [TestCase(518U,"DXVIII")]
        [TestCase(519U,"DXIX")]
        [TestCase(520U,"DXX")]
        [TestCase(521U,"DXXI")]
        [TestCase(522U,"DXXII")]
        [TestCase(523U,"DXXIII")]
        [TestCase(524U,"DXXIV")]
        [TestCase(525U,"DXXV")]
        [TestCase(526U,"DXXVI")]
        [TestCase(527U,"DXXVII")]
        [TestCase(528U,"DXXVIII")]
        [TestCase(529U,"DXXIX")]
        [TestCase(530U,"DXXX")]
        [TestCase(531U,"DXXXI")]
        [TestCase(532U,"DXXXII")]
        [TestCase(533U,"DXXXIII")]
        [TestCase(534U,"DXXXIV")]
        [TestCase(535U,"DXXXV")]
        [TestCase(536U,"DXXXVI")]
        [TestCase(537U,"DXXXVII")]
        [TestCase(538U,"DXXXVIII")]
        [TestCase(539U,"DXXXIX")]
        [TestCase(540U,"DXL")]
        [TestCase(541U,"DXLI")]
        [TestCase(542U,"DXLII")]
        [TestCase(543U,"DXLIII")]
        [TestCase(544U,"DXLIV")]
        [TestCase(545U,"DXLV")]
        [TestCase(546U,"DXLVI")]
        [TestCase(547U,"DXLVII")]
        [TestCase(548U,"DXLVIII")]
        [TestCase(549U,"DXLIX")]
        [TestCase(550U,"DL")]
        [TestCase(551U,"DLI")]
        [TestCase(552U,"DLII")]
        [TestCase(553U,"DLIII")]
        [TestCase(554U,"DLIV")]
        [TestCase(555U,"DLV")]
        [TestCase(556U,"DLVI")]
        [TestCase(557U,"DLVII")]
        [TestCase(558U,"DLVIII")]
        [TestCase(559U,"DLIX")]
        [TestCase(560U,"DLX")]
        [TestCase(561U,"DLXI")]
        [TestCase(562U,"DLXII")]
        [TestCase(563U,"DLXIII")]
        [TestCase(564U,"DLXIV")]
        [TestCase(565U,"DLXV")]
        [TestCase(566U,"DLXVI")]
        [TestCase(567U,"DLXVII")]
        [TestCase(568U,"DLXVIII")]
        [TestCase(569U,"DLXIX")]
        [TestCase(570U,"DLXX")]
        [TestCase(571U,"DLXXI")]
        [TestCase(572U,"DLXXII")]
        [TestCase(573U,"DLXXIII")]
        [TestCase(574U,"DLXXIV")]
        [TestCase(575U,"DLXXV")]
        [TestCase(576U,"DLXXVI")]
        [TestCase(577U,"DLXXVII")]
        [TestCase(578U,"DLXXVIII")]
        [TestCase(579U,"DLXXIX")]
        [TestCase(580U,"DLXXX")]
        [TestCase(581U,"DLXXXI")]
        [TestCase(582U,"DLXXXII")]
        [TestCase(583U,"DLXXXIII")]
        [TestCase(584U,"DLXXXIV")]
        [TestCase(585U,"DLXXXV")]
        [TestCase(586U,"DLXXXVI")]
        [TestCase(587U,"DLXXXVII")]
        [TestCase(588U,"DLXXXVIII")]
        [TestCase(589U,"DLXXXIX")]
        [TestCase(590U,"DXC")]
        [TestCase(591U,"DXCI")]
        [TestCase(592U,"DXCII")]
        [TestCase(593U,"DXCIII")]
        [TestCase(594U,"DXCIV")]
        [TestCase(595U,"DXCV")]
        [TestCase(596U,"DXCVI")]
        [TestCase(597U,"DXCVII")]
        [TestCase(598U,"DXCVIII")]
        [TestCase(599U,"DXCIX")]
        [TestCase(600U,"DC")]
        [TestCase(601U,"DCI")]
        [TestCase(602U,"DCII")]
        [TestCase(603U,"DCIII")]
        [TestCase(604U,"DCIV")]
        [TestCase(605U,"DCV")]
        [TestCase(606U,"DCVI")]
        [TestCase(607U,"DCVII")]
        [TestCase(608U,"DCVIII")]
        [TestCase(609U,"DCIX")]
        [TestCase(610U,"DCX")]
        [TestCase(611U,"DCXI")]
        [TestCase(612U,"DCXII")]
        [TestCase(613U,"DCXIII")]
        [TestCase(614U,"DCXIV")]
        [TestCase(615U,"DCXV")]
        [TestCase(616U,"DCXVI")]
        [TestCase(617U,"DCXVII")]
        [TestCase(618U,"DCXVIII")]
        [TestCase(619U,"DCXIX")]
        [TestCase(620U,"DCXX")]
        [TestCase(621U,"DCXXI")]
        [TestCase(622U,"DCXXII")]
        [TestCase(623U,"DCXXIII")]
        [TestCase(624U,"DCXXIV")]
        [TestCase(625U,"DCXXV")]
        [TestCase(626U,"DCXXVI")]
        [TestCase(627U,"DCXXVII")]
        [TestCase(628U,"DCXXVIII")]
        [TestCase(629U,"DCXXIX")]
        [TestCase(630U,"DCXXX")]
        [TestCase(631U,"DCXXXI")]
        [TestCase(632U,"DCXXXII")]
        [TestCase(633U,"DCXXXIII")]
        [TestCase(634U,"DCXXXIV")]
        [TestCase(635U,"DCXXXV")]
        [TestCase(636U,"DCXXXVI")]
        [TestCase(637U,"DCXXXVII")]
        [TestCase(638U,"DCXXXVIII")]
        [TestCase(639U,"DCXXXIX")]
        [TestCase(640U,"DCXL")]
        [TestCase(641U,"DCXLI")]
        [TestCase(642U,"DCXLII")]
        [TestCase(643U,"DCXLIII")]
        [TestCase(644U,"DCXLIV")]
        [TestCase(645U,"DCXLV")]
        [TestCase(646U,"DCXLVI")]
        [TestCase(647U,"DCXLVII")]
        [TestCase(648U,"DCXLVIII")]
        [TestCase(649U,"DCXLIX")]
        [TestCase(650U,"DCL")]
        [TestCase(651U,"DCLI")]
        [TestCase(652U,"DCLII")]
        [TestCase(653U,"DCLIII")]
        [TestCase(654U,"DCLIV")]
        [TestCase(655U,"DCLV")]
        [TestCase(656U,"DCLVI")]
        [TestCase(657U,"DCLVII")]
        [TestCase(658U,"DCLVIII")]
        [TestCase(659U,"DCLIX")]
        [TestCase(660U,"DCLX")]
        [TestCase(661U,"DCLXI")]
        [TestCase(662U,"DCLXII")]
        [TestCase(663U,"DCLXIII")]
        [TestCase(664U,"DCLXIV")]
        [TestCase(665U,"DCLXV")]
        [TestCase(666U,"DCLXVI")]
        [TestCase(667U,"DCLXVII")]
        [TestCase(668U,"DCLXVIII")]
        [TestCase(669U,"DCLXIX")]
        [TestCase(670U,"DCLXX")]
        [TestCase(671U,"DCLXXI")]
        [TestCase(672U,"DCLXXII")]
        [TestCase(673U,"DCLXXIII")]
        [TestCase(674U,"DCLXXIV")]
        [TestCase(675U,"DCLXXV")]
        [TestCase(676U,"DCLXXVI")]
        [TestCase(677U,"DCLXXVII")]
        [TestCase(678U,"DCLXXVIII")]
        [TestCase(679U,"DCLXXIX")]
        [TestCase(680U,"DCLXXX")]
        [TestCase(681U,"DCLXXXI")]
        [TestCase(682U,"DCLXXXII")]
        [TestCase(683U,"DCLXXXIII")]
        [TestCase(684U,"DCLXXXIV")]
        [TestCase(685U,"DCLXXXV")]
        [TestCase(686U,"DCLXXXVI")]
        [TestCase(687U,"DCLXXXVII")]
        [TestCase(688U,"DCLXXXVIII")]
        [TestCase(689U,"DCLXXXIX")]
        [TestCase(690U,"DCXC")]
        [TestCase(691U,"DCXCI")]
        [TestCase(692U,"DCXCII")]
        [TestCase(693U,"DCXCIII")]
        [TestCase(694U,"DCXCIV")]
        [TestCase(695U,"DCXCV")]
        [TestCase(696U,"DCXCVI")]
        [TestCase(697U,"DCXCVII")]
        [TestCase(698U,"DCXCVIII")]
        [TestCase(699U,"DCXCIX")]
        [TestCase(700U,"DCC")]
        [TestCase(701U,"DCCI")]
        [TestCase(702U,"DCCII")]
        [TestCase(703U,"DCCIII")]
        [TestCase(704U,"DCCIV")]
        [TestCase(705U,"DCCV")]
        [TestCase(706U,"DCCVI")]
        [TestCase(707U,"DCCVII")]
        [TestCase(708U,"DCCVIII")]
        [TestCase(709U,"DCCIX")]
        [TestCase(710U,"DCCX")]
        [TestCase(711U,"DCCXI")]
        [TestCase(712U,"DCCXII")]
        [TestCase(713U,"DCCXIII")]
        [TestCase(714U,"DCCXIV")]
        [TestCase(715U,"DCCXV")]
        [TestCase(716U,"DCCXVI")]
        [TestCase(717U,"DCCXVII")]
        [TestCase(718U,"DCCXVIII")]
        [TestCase(719U,"DCCXIX")]
        [TestCase(720U,"DCCXX")]
        [TestCase(721U,"DCCXXI")]
        [TestCase(722U,"DCCXXII")]
        [TestCase(723U,"DCCXXIII")]
        [TestCase(724U,"DCCXXIV")]
        [TestCase(725U,"DCCXXV")]
        [TestCase(726U,"DCCXXVI")]
        [TestCase(727U,"DCCXXVII")]
        [TestCase(728U,"DCCXXVIII")]
        [TestCase(729U,"DCCXXIX")]
        [TestCase(730U,"DCCXXX")]
        [TestCase(731U,"DCCXXXI")]
        [TestCase(732U,"DCCXXXII")]
        [TestCase(733U,"DCCXXXIII")]
        [TestCase(734U,"DCCXXXIV")]
        [TestCase(735U,"DCCXXXV")]
        [TestCase(736U,"DCCXXXVI")]
        [TestCase(737U,"DCCXXXVII")]
        [TestCase(738U,"DCCXXXVIII")]
        [TestCase(739U,"DCCXXXIX")]
        [TestCase(740U,"DCCXL")]
        [TestCase(741U,"DCCXLI")]
        [TestCase(742U,"DCCXLII")]
        [TestCase(743U,"DCCXLIII")]
        [TestCase(744U,"DCCXLIV")]
        [TestCase(745U,"DCCXLV")]
        [TestCase(746U,"DCCXLVI")]
        [TestCase(747U,"DCCXLVII")]
        [TestCase(748U,"DCCXLVIII")]
        [TestCase(749U,"DCCXLIX")]
        [TestCase(750U,"DCCL")]
        [TestCase(751U,"DCCLI")]
        [TestCase(752U,"DCCLII")]
        [TestCase(753U,"DCCLIII")]
        [TestCase(754U,"DCCLIV")]
        [TestCase(755U,"DCCLV")]
        [TestCase(756U,"DCCLVI")]
        [TestCase(757U,"DCCLVII")]
        [TestCase(758U,"DCCLVIII")]
        [TestCase(759U,"DCCLIX")]
        [TestCase(760U,"DCCLX")]
        [TestCase(761U,"DCCLXI")]
        [TestCase(762U,"DCCLXII")]
        [TestCase(763U,"DCCLXIII")]
        [TestCase(764U,"DCCLXIV")]
        [TestCase(765U,"DCCLXV")]
        [TestCase(766U,"DCCLXVI")]
        [TestCase(767U,"DCCLXVII")]
        [TestCase(768U,"DCCLXVIII")]
        [TestCase(769U,"DCCLXIX")]
        [TestCase(770U,"DCCLXX")]
        [TestCase(771U,"DCCLXXI")]
        [TestCase(772U,"DCCLXXII")]
        [TestCase(773U,"DCCLXXIII")]
        [TestCase(774U,"DCCLXXIV")]
        [TestCase(775U,"DCCLXXV")]
        [TestCase(776U,"DCCLXXVI")]
        [TestCase(777U,"DCCLXXVII")]
        [TestCase(778U,"DCCLXXVIII")]
        [TestCase(779U,"DCCLXXIX")]
        [TestCase(780U,"DCCLXXX")]
        [TestCase(781U,"DCCLXXXI")]
        [TestCase(782U,"DCCLXXXII")]
        [TestCase(783U,"DCCLXXXIII")]
        [TestCase(784U,"DCCLXXXIV")]
        [TestCase(785U,"DCCLXXXV")]
        [TestCase(786U,"DCCLXXXVI")]
        [TestCase(787U,"DCCLXXXVII")]
        [TestCase(788U,"DCCLXXXVIII")]
        [TestCase(789U,"DCCLXXXIX")]
        [TestCase(790U,"DCCXC")]
        [TestCase(791U,"DCCXCI")]
        [TestCase(792U,"DCCXCII")]
        [TestCase(793U,"DCCXCIII")]
        [TestCase(794U,"DCCXCIV")]
        [TestCase(795U,"DCCXCV")]
        [TestCase(796U,"DCCXCVI")]
        [TestCase(797U,"DCCXCVII")]
        [TestCase(798U,"DCCXCVIII")]
        [TestCase(799U,"DCCXCIX")]
        [TestCase(800U,"DCCC")]
        [TestCase(801U,"DCCCI")]
        [TestCase(802U,"DCCCII")]
        [TestCase(803U,"DCCCIII")]
        [TestCase(804U,"DCCCIV")]
        [TestCase(805U,"DCCCV")]
        [TestCase(806U,"DCCCVI")]
        [TestCase(807U,"DCCCVII")]
        [TestCase(808U,"DCCCVIII")]
        [TestCase(809U,"DCCCIX")]
        [TestCase(810U,"DCCCX")]
        [TestCase(811U,"DCCCXI")]
        [TestCase(812U,"DCCCXII")]
        [TestCase(813U,"DCCCXIII")]
        [TestCase(814U,"DCCCXIV")]
        [TestCase(815U,"DCCCXV")]
        [TestCase(816U,"DCCCXVI")]
        [TestCase(817U,"DCCCXVII")]
        [TestCase(818U,"DCCCXVIII")]
        [TestCase(819U,"DCCCXIX")]
        [TestCase(820U,"DCCCXX")]
        [TestCase(821U,"DCCCXXI")]
        [TestCase(822U,"DCCCXXII")]
        [TestCase(823U,"DCCCXXIII")]
        [TestCase(824U,"DCCCXXIV")]
        [TestCase(825U,"DCCCXXV")]
        [TestCase(826U,"DCCCXXVI")]
        [TestCase(827U,"DCCCXXVII")]
        [TestCase(828U,"DCCCXXVIII")]
        [TestCase(829U,"DCCCXXIX")]
        [TestCase(830U,"DCCCXXX")]
        [TestCase(831U,"DCCCXXXI")]
        [TestCase(832U,"DCCCXXXII")]
        [TestCase(833U,"DCCCXXXIII")]
        [TestCase(834U,"DCCCXXXIV")]
        [TestCase(835U,"DCCCXXXV")]
        [TestCase(836U,"DCCCXXXVI")]
        [TestCase(837U,"DCCCXXXVII")]
        [TestCase(838U,"DCCCXXXVIII")]
        [TestCase(839U,"DCCCXXXIX")]
        [TestCase(840U,"DCCCXL")]
        [TestCase(841U,"DCCCXLI")]
        [TestCase(842U,"DCCCXLII")]
        [TestCase(843U,"DCCCXLIII")]
        [TestCase(844U,"DCCCXLIV")]
        [TestCase(845U,"DCCCXLV")]
        [TestCase(846U,"DCCCXLVI")]
        [TestCase(847U,"DCCCXLVII")]
        [TestCase(848U,"DCCCXLVIII")]
        [TestCase(849U,"DCCCXLIX")]
        [TestCase(850U,"DCCCL")]
        [TestCase(851U,"DCCCLI")]
        [TestCase(852U,"DCCCLII")]
        [TestCase(853U,"DCCCLIII")]
        [TestCase(854U,"DCCCLIV")]
        [TestCase(855U,"DCCCLV")]
        [TestCase(856U,"DCCCLVI")]
        [TestCase(857U,"DCCCLVII")]
        [TestCase(858U,"DCCCLVIII")]
        [TestCase(859U,"DCCCLIX")]
        [TestCase(860U,"DCCCLX")]
        [TestCase(861U,"DCCCLXI")]
        [TestCase(862U,"DCCCLXII")]
        [TestCase(863U,"DCCCLXIII")]
        [TestCase(864U,"DCCCLXIV")]
        [TestCase(865U,"DCCCLXV")]
        [TestCase(866U,"DCCCLXVI")]
        [TestCase(867U,"DCCCLXVII")]
        [TestCase(868U,"DCCCLXVIII")]
        [TestCase(869U,"DCCCLXIX")]
        [TestCase(870U,"DCCCLXX")]
        [TestCase(871U,"DCCCLXXI")]
        [TestCase(872U,"DCCCLXXII")]
        [TestCase(873U,"DCCCLXXIII")]
        [TestCase(874U,"DCCCLXXIV")]
        [TestCase(875U,"DCCCLXXV")]
        [TestCase(876U,"DCCCLXXVI")]
        [TestCase(877U,"DCCCLXXVII")]
        [TestCase(878U,"DCCCLXXVIII")]
        [TestCase(879U,"DCCCLXXIX")]
        [TestCase(880U,"DCCCLXXX")]
        [TestCase(881U,"DCCCLXXXI")]
        [TestCase(882U,"DCCCLXXXII")]
        [TestCase(883U,"DCCCLXXXIII")]
        [TestCase(884U,"DCCCLXXXIV")]
        [TestCase(885U,"DCCCLXXXV")]
        [TestCase(886U,"DCCCLXXXVI")]
        [TestCase(887U,"DCCCLXXXVII")]
        [TestCase(888U,"DCCCLXXXVIII")]
        [TestCase(889U,"DCCCLXXXIX")]
        [TestCase(890U,"DCCCXC")]
        [TestCase(891U,"DCCCXCI")]
        [TestCase(892U,"DCCCXCII")]
        [TestCase(893U,"DCCCXCIII")]
        [TestCase(894U,"DCCCXCIV")]
        [TestCase(895U,"DCCCXCV")]
        [TestCase(896U,"DCCCXCVI")]
        [TestCase(897U,"DCCCXCVII")]
        [TestCase(898U,"DCCCXCVIII")]
        [TestCase(899U,"DCCCXCIX")]
        [TestCase(900U,"CM")]
        [TestCase(901U,"CMI")]
        [TestCase(902U,"CMII")]
        [TestCase(903U,"CMIII")]
        [TestCase(904U,"CMIV")]
        [TestCase(905U,"CMV")]
        [TestCase(906U,"CMVI")]
        [TestCase(907U,"CMVII")]
        [TestCase(908U,"CMVIII")]
        [TestCase(909U,"CMIX")]
        [TestCase(910U,"CMX")]
        [TestCase(911U,"CMXI")]
        [TestCase(912U,"CMXII")]
        [TestCase(913U,"CMXIII")]
        [TestCase(914U,"CMXIV")]
        [TestCase(915U,"CMXV")]
        [TestCase(916U,"CMXVI")]
        [TestCase(917U,"CMXVII")]
        [TestCase(918U,"CMXVIII")]
        [TestCase(919U,"CMXIX")]
        [TestCase(920U,"CMXX")]
        [TestCase(921U,"CMXXI")]
        [TestCase(922U,"CMXXII")]
        [TestCase(923U,"CMXXIII")]
        [TestCase(924U,"CMXXIV")]
        [TestCase(925U,"CMXXV")]
        [TestCase(926U,"CMXXVI")]
        [TestCase(927U,"CMXXVII")]
        [TestCase(928U,"CMXXVIII")]
        [TestCase(929U,"CMXXIX")]
        [TestCase(930U,"CMXXX")]
        [TestCase(931U,"CMXXXI")]
        [TestCase(932U,"CMXXXII")]
        [TestCase(933U,"CMXXXIII")]
        [TestCase(934U,"CMXXXIV")]
        [TestCase(935U,"CMXXXV")]
        [TestCase(936U,"CMXXXVI")]
        [TestCase(937U,"CMXXXVII")]
        [TestCase(938U,"CMXXXVIII")]
        [TestCase(939U,"CMXXXIX")]
        [TestCase(940U,"CMXL")]
        [TestCase(941U,"CMXLI")]
        [TestCase(942U,"CMXLII")]
        [TestCase(943U,"CMXLIII")]
        [TestCase(944U,"CMXLIV")]
        [TestCase(945U,"CMXLV")]
        [TestCase(946U,"CMXLVI")]
        [TestCase(947U,"CMXLVII")]
        [TestCase(948U,"CMXLVIII")]
        [TestCase(949U,"CMXLIX")]
        [TestCase(950U,"CML")]
        [TestCase(951U,"CMLI")]
        [TestCase(952U,"CMLII")]
        [TestCase(953U,"CMLIII")]
        [TestCase(954U,"CMLIV")]
        [TestCase(955U,"CMLV")]
        [TestCase(956U,"CMLVI")]
        [TestCase(957U,"CMLVII")]
        [TestCase(958U,"CMLVIII")]
        [TestCase(959U,"CMLIX")]
        [TestCase(960U,"CMLX")]
        [TestCase(961U,"CMLXI")]
        [TestCase(962U,"CMLXII")]
        [TestCase(963U,"CMLXIII")]
        [TestCase(964U,"CMLXIV")]
        [TestCase(965U,"CMLXV")]
        [TestCase(966U,"CMLXVI")]
        [TestCase(967U,"CMLXVII")]
        [TestCase(968U,"CMLXVIII")]
        [TestCase(969U,"CMLXIX")]
        [TestCase(970U,"CMLXX")]
        [TestCase(971U,"CMLXXI")]
        [TestCase(972U,"CMLXXII")]
        [TestCase(973U,"CMLXXIII")]
        [TestCase(974U,"CMLXXIV")]
        [TestCase(975U,"CMLXXV")]
        [TestCase(976U,"CMLXXVI")]
        [TestCase(977U,"CMLXXVII")]
        [TestCase(978U,"CMLXXVIII")]
        [TestCase(979U,"CMLXXIX")]
        [TestCase(980U,"CMLXXX")]
        [TestCase(981U,"CMLXXXI")]
        [TestCase(982U,"CMLXXXII")]
        [TestCase(983U,"CMLXXXIII")]
        [TestCase(984U,"CMLXXXIV")]
        [TestCase(985U,"CMLXXXV")]
        [TestCase(986U,"CMLXXXVI")]
        [TestCase(987U,"CMLXXXVII")]
        [TestCase(988U,"CMLXXXVIII")]
        [TestCase(989U,"CMLXXXIX")]
        [TestCase(990U,"CMXC")]
        [TestCase(991U,"CMXCI")]
        [TestCase(992U,"CMXCII")]
        [TestCase(993U,"CMXCIII")]
        [TestCase(994U,"CMXCIV")]
        [TestCase(995U,"CMXCV")]
        [TestCase(996U,"CMXCVI")]
        [TestCase(997U,"CMXCVII")]
        [TestCase(998U,"CMXCVIII")]
        [TestCase(999U,"CMXCIX")]
        [TestCase(1000U,"M")]
        public void TestRomanNumberConvertion(uint number, string expected)
        {
            var actual = number.ToRomanNumber();
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
