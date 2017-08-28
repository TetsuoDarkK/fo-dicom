// Copyright (c) 2012-2017 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace Dicom
{
    public partial class DicomAnonymizer
    {
        public partial class SecurityProfile
        {
            /// <summary>
            /// De-identification map taken from DICOM PS 3.15: http://dicom.nema.org/medical/dicom/current/output/chtml/part15/PS3.15.html
            /// </summary>
            /// <remarks>
            /// The CSV columns are:
            /// - Tag (regex)
            /// - BasicProfile
            /// - RetainSafePrivateOption
            /// - RetainUIDsOption
            /// - RetainDeviceIdentOption
            /// - RetainPatientCharsOption
            /// - RetainLongFullDatesOption
            /// - RetainLongModifDatesOption
            /// - CleanDescOption
            /// - CleanStructdContOption
            /// - CleanGraphOption
            /// </remarks>
            private const string DefaultProfile = @"
                [0-9A-F]{3}[13579BDF],[0-9A-F]{4};X;C;;;;;;;;
                50[0-9A-F]{2},[0-9A-F]{4};X;;;;;;;;;C
                60[0-9A-F]{2},4000;X;;;;;;;;;C
                60[0-9A-F]{2},3000;X;;;;;;;;;C                
                0008,0050;Z;;;;;;;;;
                0018,4000;X;;;;;;;C;;
                0040,0555;X;;;;;;;;C;
                0008,0022;X/Z;;;;;K;C;;;
                0008,002A;X/D;;;;;K;C;;;
                0018,1400;X/D;;;;;;;C;;
                0018,9424;X;;;;;;;C;;
                0008,0032;X/Z;;;;;K;C;;;
                0040,4035;X;;;;;;;;;
                0010,21B0;X;;;;;;;C;;
                0038,0010;X;;;;;;;;;
                0038,0020;X;;;;;K;C;;;
                0008,1084;X;;;;;;;C;;
                0008,1080;X;;;;;;;C;;
                0038,0021;X;;;;;K;C;;;
                0000,1000;X;;K;;;;;;;
                0010,2110;X;;;;C;;;C;;
                4000,0010;X;;;;;;;;;
                0040,A078;X;;;;;;;;;
                0010,1081;X;;;;;;;;;
                0018,1007;X;;;K;;;;;;
                0040,0280;X;;;;;;;C;;
                0020,9161;U;;K;;;;;;;
                0040,3001;X;;;;;;;;;
                0070,0086;X;;;;;;;;;
                0070,0084;Z;;;;;;;;;
                0008,0023;Z/D;;;;;K;C;;;
                0040,A730;X;;;;;;;;C;
                0008,0033;Z/D;;;;;K;C;;;
                0008,010D;U;;K;;;;;;;
                0018,0010;Z/D;;;;;;;C;;
                0018,A003;X;;;;;;;C;;
                0010,2150;X;;;;;;;;;
                0008,9123;U;;K;;;;;;;
                0038,0300;X;;;;;;;;;
                0008,0025;X;;;;;K;C;;;
                0008,0035;X;;;;;K;C;;;
                0040,A07C;X;;;;;;;;;
                FFFC,FFFC;X;;;;;;;;;
                0008,2111;X;;;;;;;C;;
                0018,700A;X;;;K;;;;;;
                0018,1000;X/Z/D;;;K;;;;;;
                0018,1002;U;;K;K;;;;;;
                0400,0100;X;;;;;;;;;
                FFFA,FFFA;X;;;;;;;;;
                0020,9164;U;;K;;;;;;;
                0038,0040;X;;;;;;;C;;
                4008,011A;X;;;;;;;;;
                4008,0119;X;;;;;;;;;
                300A,0013;U;;K;;;;;;;
                0010,2160;X;;;;K;;;;;
                0008,0058;U;;K;;;;;;;
                0070,031A;U;;K;;;;;;;
                0040,2017;Z;;;;;;;;;
                0020,9158;X;;;;;;;C;;
                0020,0052;U;;K;;;;;;;
                0018,1008;X;;;K;;;;;;
                0018,1005;X;;;K;;;;;;
                0070,0001;D;;;;;;;;;C
                0040,4037;X;;;;;;;;;
                0040,4036;X;;;;;;;;;
                0088,0200;X;;;;;;;;;
                0008,4000;X;;;;;;;C;;
                0020,4000;X;;;;;;;C;;
                0028,4000;X;;;;;;;;;
                0040,2400;X;;;;;;;C;;
                4008,0300;X;;;;;;;C;;
                0008,0014;U;;K;;;;;;;
                0008,0081;X;;;;;;;;;
                0008,0082;X/Z/D;;;;;;;;;
                0008,0080;X/Z/D;;;;;;;;;
                0008,1040;X;;;;;;;;;
                0010,1050;X;;;;;;;;;
                0040,1011;X;;;;;;;;;
                4008,0111;X;;;;;;;;;
                4008,010C;X;;;;;;;;;
                4008,0115;X;;;;;;;C;;
                4008,0202;X;;;;;;;;;
                4008,0102;X;;;;;;;;;
                4008,010B;X;;;;;;;C;;
                4008,010A;X;;;;;;;;;
                0008,3010;U;;K;;;;;;;
                0038,0011;X;;;;;;;;;
                0010,0021;X;;;;;;;;;
                0038,0061;X;;;;;;;;;
                0028,1214;U;;K;;;;;;;
                0010,21D0;X;;;;;K;C;;;
                0400,0404;X;;;;;;;;;
                0002,0003;U;;K;;;;;;;
                0010,2000;X;;;;;;;C;;
                0010,1090;X;;;;;;;;;
                0010,1080;X;;;;;;;;;
                0400,0550;X;;;;;;;;;
                0020,3406;X;;;;;;;;;
                0020,3401;X;;;;;;;;;
                0020,3404;X;;;;;;;;;
                0008,1060;X;;;;;;;;;
                0040,1010;X;;;;;;;;;
                0010,2180;X;;;;;;;C;;
                0008,1072;X/D;;;;;;;;;
                0008,1070;X/Z/D;;;;;;;;;
                0040,2010;X;;;;;;;;;
                0040,2008;X;;;;;;;;;
                0040,2009;X;;;;;;;;;
                0400,0561;X;;;;;;;;;
                0010,1000;X;;;;;;;;;
                0010,1002;X;;;;;;;;;
                0010,1001;X;;;;;;;;;
                0008,0024;X;;;;;K;C;;;
                0008,0034;X;;;;;K;C;;;
                0028,1199;U;;K;;;;;;;
                0040,A07A;X;;;;;;;;;
                0010,1040;X;;;;;;;;;
                0010,4000;X;;;;;;;C;;
                0010,0020;Z;;;;;;;;;
                0010,2203;X/Z;;;;K;;;;;
                0038,0500;X;;;;C;;;C;;
                0040,1004;X;;;;;;;;;
                0010,1010;X;;;;K;;;;;
                0010,0030;Z;;;;;;;;;
                0010,1005;X;;;;;;;;;
                0010,0032;X;;;;;;;;;
                0038,0400;X;;;;;;;;;
                0010,0050;X;;;;;;;;;
                0010,1060;X;;;;;;;;;
                0010,0010;Z;;;;;;;;;
                0010,0101;X;;;;;;;;;
                0010,0102;X;;;;;;;;;
                0010,21F0;X;;;;;;;;;
                0010,0040;Z;;;;K;;;;;
                0010,1020;X;;;;K;;;;;
                0010,2154;X;;;;;;;;;
                0010,1030;X;;;;K;;;;;
                0040,0243;X;;;;;;;;;
                0040,0254;X;;;;;;;C;;
                0040,0253;X;;;;;;;;;
                0040,0244;X;;;;;K;C;;;
                0040,0245;X;;;;;K;C;;;
                0040,0241;X;;;K;;;;;;
                0040,4030;X;;;K;;;;;;
                0040,0242;X;;;K;;;;;;
                0040,0248;X;;;K;;;;;;
                0008,1052;X;;;;;;;;;
                0008,1050;X;;;;;;;;;
                0040,1102;X;;;;;;;;;
                0040,1101;D;;;;;;;;;
                0040,A123;D;;;;;;;;;
                0040,1103;X;;;;;;;;;
                4008,0114;X;;;;;;;;;
                0008,1062;X;;;;;;;;;
                0008,1048;X;;;;;;;;;
                0008,1049;X;;;;;;;;;
                0040,2016;Z;;;;;;;;;
                0018,1004;X;;;K;;;;;;
                0010,21C0;X;;;;K;;;;;
                0040,0012;X;;;;C;;;;;
                0018,1030;X/D;;;;;;;C;;
                0040,2001;X;;;;;;;C;;
                0032,1030;X;;;;;;;C;;
                0400,0402;X;;;;;;;;;
                3006,0024;U;;K;;;;;;;
                0040,4023;U;;K;;;;;;;
                0008,1140;X/Z/U*;;K;;;;;;;
                0038,1234;X;;;;;;;;;
                0008,1120;X;;X;;;;;;;
                0008,1111;X/Z/D;;K;;;;;;;
                0400,0403;X;;;;;;;;;
                0008,1155;U;;K;;;;;;;
                0004,1511;U;;K;;;;;;;
                0008,1110;X/Z;;K;;;;;;;
                0008,0092;X;;;;;;;;;
                0008,0096;X;;;;;;;;;
                0008,0090;Z;;;;;;;;;
                0008,0094;X;;;;;;;;;
                0010,2152;X;;;;;;;;;
                3006,00C2;U;;K;;;;;;;
                0040,0275;X;;;;;;;C;;
                0032,1070;X;;;;;;;C;;
                0040,1400;X;;;;;;;C;;
                0032,1060;X/Z;;;;;;;C;;
                0040,1001;X;;;;;;;;;
                0040,1005;X;;;;;;;;;
                0000,1001;U;;K;;;;;;;
                0032,1032;X;;;;;;;;;
                0032,1033;X;;;;;;;;;
                0010,2299;X;;;;;;;;;
                0010,2297;X;;;;;;;;;
                4008,4000;X;;;;;;;C;;
                4008,0118;X;;;;;;;;;
                4008,0042;X;;;;;;;;;
                300E,0008;X/Z;;;;;;;;;
                0040,4034;X;;;;;;;;;
                0038,001E;X;;;;;;;;;
                0040,000B;X;;;;;;;;;
                0040,0006;X;;;;;;;;;
                0040,0007;X;;;;;;;C;;
                0040,0004;X;;;;;K;C;;;
                0040,0005;X;;;;;K;C;;;
                0040,0011;X;;;K;;;;;;
                0040,0002;X;;;;;K;C;;;
                0040,0003;X;;;;;K;C;;;
                0040,0001;X;;;K;;;;;;
                0040,4027;X;;;K;;;;;;
                0040,0010;X;;;K;;;;;;
                0040,4025;X;;;K;;;;;;
                0032,1020;X;;;K;;;;;;
                0032,1021;X;;;K;;;;;;
                0008,0021;X/D;;;;;K;C;;;
                0008,103E;X;;;;;;;C;;
                0020,000E;U;;K;;;;;;;
                0008,0031;X/D;;;;;K;C;;;
                0038,0062;X;;;;;;;C;;
                0038,0060;X;;;;;;;;;
                0010,21A0;X;;;;K;;;;;
                0008,0018;U;;K;;;;;;;
                0008,2112;X/Z/U*;;K;;;;;;;
                0038,0050;X;;;;C;;;;;
                0008,1010;X/Z/D;;;K;;;;;;
                0088,0140;U;;K;;;;;;;
                0032,4000;X;;;;;;;C;;
                0008,0020;Z;;;;;K;C;;;
                0008,1030;X;;;;;;;C;;
                0020,0010;Z;;;;;;;;;
                0032,0012;X;;;;;;;;;
                0020,000D;U;;K;;;;;;;
                0008,0030;Z;;;;;K;C;;;
                0020,0200;U;;K;;;;;;;
                0040,DB0D;U;;K;;;;;;;
                0040,DB0C;U;;K;;;;;;;
                4000,4000;X;;;;;;;;;
                2030,0020;X;;;;;;;;;
                0008,0201;X;;;;;K;C;;;
                0088,0910;X;;;;;;;;;
                0088,0912;X;;;;;;;;;
                0088,0906;X;;;;;;;;;
                0088,0904;X;;;;;;;;;
                0008,1195;U;;K;;;;;;;
                0040,A124;U;;;;;;;;;
                0040,A088;Z;;;;;;;;;
                0040,A075;D;;;;;;;;;
                0040,A073;D;;;;;;;;;
                0040,A027;X;;;;;;;;;
                0038,4000;X;;;;;;;C;;";
        }
    }
}
