using System.Collections.Generic;

namespace MagicNumber
{
    public class FileSignature
    {
        public static readonly Dictionary<string, List<MagicNumberRecord>> Default = new Dictionary<string, List<MagicNumberRecord>>
        {
            {
                "123", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x1A, 0x00, 0x05, 0x10, 0x04 }, Offset = 0, Size = 7 }
                }
            },
            {
                "386", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "3gp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70 }, Offset = 0, Size = 8 }
                }
            },
            {
                "3gp5", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x00, 0x18, 0x66, 0x74, 0x79, 0x70 }, Offset = 0, Size = 8 }
                }
            },
            {
                "4xm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "7z", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C }, Offset = 0, Size = 6 }
                }
            },
            {
                "aba", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x01, 0x42, 0x41 }, Offset = 0, Size = 4 }
                }
            },
            {
                "abd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "abi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x49, 0x4E, 0x44, 0x45, 0x58 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 }
                }
            },
            {
                "aby", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x44, 0x42 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 }
                }
            },
            {
                "ac", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x72, 0x69, 0x66, 0x66 }, Offset = 0, Size = 4 }
                }
            },
            {
                "accdb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x41, 0x43, 0x45, 0x20, 0x44, 0x42 }, Offset = 0, Size = 19 }
                }
            },
            {
                "acm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "acs", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xC3, 0xAB, 0xCD, 0xAB }, Offset = 0, Size = 4 }
                }
            },
            {
                "ac_", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ad", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x45, 0x56, 0x4E, 0x55, 0x4D, 0x3A, 0x2C }, Offset = 0, Size = 8 }
                }
            },
            {
                "adf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x44, 0x4F, 0x53 }, Offset = 0, Size = 3 }
                }
            },
            {
                "adp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "adx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x03, 0x00, 0x00, 0x00, 0x41, 0x50, 0x50, 0x52 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x80, 0x00, 0x00, 0x20, 0x03, 0x12, 0x04 }, Offset = 0, Size = 7 }
                }
            },
            {
                "aiff", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x46, 0x4F, 0x52, 0x4D, 0x00 }, Offset = 0, Size = 5 }
                }
            },
            {
                "ain", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x21, 0x12 }, Offset = 0, Size = 2 }
                }
            },
            {
                "amr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x21, 0x41, 0x4D, 0x52 }, Offset = 0, Size = 5 }
                }
            },
            {
                "ani", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "api", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "apr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "arc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x72, 0x43, 0x01 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x02 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x03 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x04 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x08 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x09 }, Offset = 0, Size = 2 }
                }
            },
            {
                "arj", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x60, 0xEA }, Offset = 0, Size = 2 }
                }
            },
            {
                "arl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD4, 0x2A }, Offset = 0, Size = 2 }
                }
            },
            {
                "asf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ast", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x43, 0x48, 0x6C }, Offset = 0, Size = 4 }
                }
            },
            {
                "asx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C }, Offset = 0, Size = 1 }
                }
            },
            {
                "au", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x64, 0x6E, 0x73, 0x2E }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x73, 0x6E, 0x64 }, Offset = 0, Size = 4 }
                }
            },
            {
                "aut", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD4, 0x2A }, Offset = 0, Size = 2 }
                }
            },
            {
                "avi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "aw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x8A, 0x01, 0x09, 0x00, 0x00, 0x00, 0xE1, 0x08 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ax", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "bag", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x20, 0x46, 0x65, 0x65, 0x64 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 }
                }
            },
            {
                "bdr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x58, 0x54 }, Offset = 0, Size = 2 }
                }
            },
            {
                "bin", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x4C, 0x49, 0x32, 0x32, 0x33, 0x51 }, Offset = 0, Size = 7 }
                }
            },
            {
                "bmp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x4D }, Offset = 0, Size = 2 }
                }
            },
            {
                "bz2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x5A, 0x68 }, Offset = 0, Size = 3 }
                }
            },
            {
                "cab", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x53, 0x63, 0x28 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x43, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cal", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x72, 0x63, 0x64, 0x6F, 0x63, 0x69, 0x64 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x75, 0x70, 0x65, 0x72, 0x43, 0x61, 0x6C }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xB5, 0xA2, 0xB0, 0xB3, 0xB3, 0xB0, 0xA5, 0xB5 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cap", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x58, 0x43, 0x50, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x54, 0x53, 0x53 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cas", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5F, 0x43, 0x41, 0x53, 0x45, 0x5F }, Offset = 0, Size = 6 }
                }
            },
            {
                "cat", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x30 }, Offset = 0, Size = 1 }
                }
            },
            {
                "cbd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x42, 0x46, 0x49, 0x4C, 0x45 }, Offset = 0, Size = 6 }
                }
            },
            {
                "cbk", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5F, 0x43, 0x41, 0x53, 0x45, 0x5F }, Offset = 0, Size = 6 }
                }
            },
            {
                "cda", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cdr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x4C, 0x49, 0x54, 0x45, 0x20, 0x43, 0x6F }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cfg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x66, 0x6C, 0x74, 0x73, 0x69, 0x6D, 0x2E }, Offset = 0, Size = 8 }
                }
            },
            {
                "chi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x54, 0x53, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "chm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x54, 0x53, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "class", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xCA, 0xFE, 0xBA, 0xBE }, Offset = 0, Size = 4 }
                }
            },
            {
                "clb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x4F, 0x4D, 0x2B }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x4D, 0x58, 0x31 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cmx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cnv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x51, 0x4C, 0x4F, 0x43, 0x4F, 0x4E, 0x56 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cod", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x61, 0x6D, 0x65, 0x3A, 0x20 }, Offset = 0, Size = 6 }
                }
            },
            {
                "com", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xE8 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xE9 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xEB }, Offset = 0, Size = 1 }
                }
            },
            {
                "cpe", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x46, 0x41, 0x58, 0x43, 0x4F, 0x56, 0x45, 0x52 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cpi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x49, 0x45, 0x54, 0x52, 0x4F, 0x4E, 0x49 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x46, 0x4F, 0x4E, 0x54 }, Offset = 0, Size = 5 }
                }
            },
            {
                "cpl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xDC, 0xDC }, Offset = 0, Size = 2 }
                }
            },
            {
                "cpt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x50, 0x54, 0x37, 0x46, 0x49, 0x4C, 0x45 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x50, 0x54, 0x46, 0x49, 0x4C, 0x45 }, Offset = 0, Size = 7 }
                }
            },
            {
                "cpx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cru", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x52, 0x55, 0x53, 0x48, 0x20, 0x76 }, Offset = 0, Size = 7 }
                }
            },
            {
                "crw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x49, 0x1A, 0x00, 0x00, 0x00, 0x48, 0x45 }, Offset = 0, Size = 8 }
                }
            },
            {
                "csh", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x63, 0x75, 0x73, 0x68, 0x00, 0x00, 0x00, 0x02 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ctf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x61, 0x74, 0x61, 0x6C, 0x6F, 0x67, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ctl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "cuix", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "cur", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x02, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "dat", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xA9, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6C, 0x68, 0x21 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6C, 0x68, 0x2E }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x56, 0x47, 0x36, 0x5F, 0x49, 0x6E, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x03 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x52, 0x46, 0x53, 0x53, 0x41, 0x56, 0x45 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x20, 0x55 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x6E, 0x6E, 0x6F, 0x20, 0x53, 0x65, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4E, 0x43, 0x49, 0x55, 0x4E, 0x44, 0x4F }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x45, 0x53, 0x54 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x52, 0x54, 0x53, 0x20, 0x43, 0x4F, 0x4D }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x41, 0x5A, 0x41, 0x54, 0x44, 0x42, 0x31 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x41, 0x56, 0x54, 0x52, 0x41, 0x46, 0x46 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x55, 0x46, 0x4F, 0x4F, 0x72, 0x62, 0x69, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x57, 0x4D, 0x4D, 0x50 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x52, 0x45, 0x47 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x72, 0x65, 0x67, 0x66 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xA9, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6C, 0x68, 0x21 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6C, 0x68, 0x2E }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x56, 0x47, 0x36, 0x5F, 0x49, 0x6E, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x03 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x52, 0x46, 0x53, 0x53, 0x41, 0x56, 0x45 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x20, 0x55 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x6E, 0x6E, 0x6F, 0x20, 0x53, 0x65, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4E, 0x43, 0x49, 0x55, 0x4E, 0x44, 0x4F }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x45, 0x53, 0x54 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x52, 0x54, 0x53, 0x20, 0x43, 0x4F, 0x4D }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x41, 0x5A, 0x41, 0x54, 0x44, 0x42, 0x31 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x41, 0x56, 0x54, 0x52, 0x41, 0x46, 0x46 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x55, 0x46, 0x4F, 0x4F, 0x72, 0x62, 0x69, 0x74 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x57, 0x4D, 0x4D, 0x50 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x52, 0x45, 0x47 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x72, 0x65, 0x67, 0x66 }, Offset = 0, Size = 4 }
                }
            },
            {
                "db", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x08 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x06, 0x15, 0x61, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x04, 0xD2, 0x00, 0x00, 0x10, 0x00 }, Offset = 0, Size = 16 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x44, 0x42, 0x46, 0x48 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x51, 0x4C, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x20, 0x33, 0x00 }, Offset = 0, Size = 16 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF }, Offset = 512, Size = 4 }
                }
            },
            {
                "db3", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x03 }, Offset = 0, Size = 1 }
                }
            },
            {
                "db4", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x04 }, Offset = 0, Size = 1 }
                }
            },
            {
                "dba", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x01, 0x42, 0x44 }, Offset = 0, Size = 4 }
                }
            },
            {
                "dbb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x6C, 0x33, 0x33, 0x6C }, Offset = 0, Size = 4 }
                }
            },
            {
                "dbf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x50, 0x4C, 0x44, 0x61, 0x74, 0x61, 0x62 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dbx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xCF, 0xAD, 0x12, 0xFE }, Offset = 0, Size = 4 }
                }
            },
            {
                "dci", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x21, 0x64, 0x6F, 0x63, 0x74, 0x79, 0x70 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dcx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xB1, 0x68, 0xDE, 0x3A }, Offset = 0, Size = 4 }
                }
            },
            {
                "dex", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x64, 0x65, 0x78, 0x0A, 0x30, 0x30, 0x39, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dib", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x4D }, Offset = 0, Size = 2 }
                }
            },
            {
                "dll", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "dmg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x78 }, Offset = 0, Size = 1 }
                }
            },
            {
                "dmp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 }, Offset = 0, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x41, 0x47, 0x45, 0x44, 0x55 }, Offset = 0, Size = 6 }
                }
            },
            {
                "dms", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x44, 0x4D, 0x53, 0x21 }, Offset = 0, Size = 4 }
                }
            },
            {
                "doc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x0D, 0x44, 0x4F, 0x43 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xDB, 0xA5, 0x2D, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xEC, 0xA5, 0xC1, 0x00 }, Offset = 512, Size = 4 }
                }
            },
            {
                "docx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dot", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "drv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "drw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x07 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x01, 0xFF, 0x02, 0x04, 0x03, 0x02 }, Offset = 0, Size = 6 }
                }
            },
            {
                "ds4", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "dsn", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x56 }, Offset = 0, Size = 2 }
                }
            },
            {
                "dsp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dss", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x02, 0x64, 0x73, 0x73 }, Offset = 0, Size = 4 }
                }
            },
            {
                "dsw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x64, 0x73, 0x77, 0x66, 0x69, 0x6C, 0x65 }, Offset = 0, Size = 7 }
                }
            },
            {
                "dtd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x07, 0x64, 0x74, 0x32, 0x64, 0x64, 0x74, 0x64 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dun", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x50, 0x68, 0x6F, 0x6E, 0x65, 0x5D }, Offset = 0, Size = 7 }
                }
            },
            {
                "dvf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, Offset = 0, Size = 8 }
                }
            },
            {
                "dvr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x44, 0x56, 0x44 }, Offset = 0, Size = 3 }
                }
            },
            {
                "dw4", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x7B }, Offset = 0, Size = 2 }
                }
            },
            {
                "dwg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x43, 0x31, 0x30 }, Offset = 0, Size = 4 }
                }
            },
            {
                "e01", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ecf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x6C }, Offset = 0, Size = 8 }
                }
            },
            {
                "efx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xDC, 0xFE }, Offset = 0, Size = 2 }
                }
            },
            {
                "eml", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x58, 0x2D }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x65, 0x74, 0x75, 0x72, 0x6E, 0x2D, 0x50 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x46, 0x72, 0x6F, 0x6D }, Offset = 0, Size = 4 }
                }
            },
            {
                "enl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x40, 0x40, 0x40, 0x20, 0x00, 0x00, 0x40, 0x40, 0x40, 0x40 }, Offset = 32, Size = 10 }
                }
            },
            {
                "eps", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xC5, 0xD0, 0xD3, 0xC6 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F }, Offset = 0, Size = 8 }
                }
            },
            {
                "eth", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x35, 0x01, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "evt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x30, 0x00, 0x00, 0x00, 0x4C, 0x66, 0x4C, 0x65 }, Offset = 0, Size = 8 }
                }
            },
            {
                "evtx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x6C, 0x66, 0x46, 0x69, 0x6C, 0x65, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "exe", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "fdf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x25, 0x50, 0x44, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "flac", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x66, 0x4C, 0x61, 0x43, 0x00, 0x00, 0x00, 0x22 }, Offset = 0, Size = 8 }
                }
            },
            {
                "fli", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x11 }, Offset = 0, Size = 2 }
                }
            },
            {
                "flt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x76, 0x32, 0x30, 0x30, 0x33, 0x2E, 0x31, 0x30 }, Offset = 0, Size = 8 }
                }
            },
            {
                "flv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x46, 0x4C, 0x56 }, Offset = 0, Size = 3 }
                }
            },
            {
                "fm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x4D, 0x61, 0x6B, 0x65, 0x72, 0x46, 0x69 }, Offset = 0, Size = 8 }
                }
            },
            {
                "fon", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "ftr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD2, 0x0A, 0x00, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "gho", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFE, 0xEF }, Offset = 0, Size = 2 }
                }
            },
            {
                "ghs", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFE, 0xEF }, Offset = 0, Size = 2 }
                }
            },
            {
                "gid", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3F, 0x5F, 0x03, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x4E, 0x02, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "gif", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x47, 0x49, 0x46, 0x38 }, Offset = 0, Size = 4 }
                }
            },
            {
                "gpg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x99 }, Offset = 0, Size = 1 }
                }
            },
            {
                "grp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4D, 0x43, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "gx2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x47, 0x58, 0x32 }, Offset = 0, Size = 3 }
                }
            },
            {
                "gz", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1F, 0x8B, 0x08 }, Offset = 0, Size = 3 }
                }
            },
            {
                "hap", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x91, 0x33, 0x48, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "hdmp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 }, Offset = 0, Size = 6 }
                }
            },
            {
                "hdr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x53, 0x63, 0x28 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x3F, 0x52, 0x41, 0x44, 0x49, 0x41, 0x4E }, Offset = 0, Size = 8 }
                }
            },
            {
                "hip", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x48, 0x69, 0x50, 0x21 }, Offset = 0, Size = 0 }
                }
            },
            {
                "hlp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF }, Offset = 7, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x3F, 0x5F, 0x03, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x4E, 0x02, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "hqx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x28, 0x54, 0x68, 0x69, 0x73, 0x20, 0x66, 0x69 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ico", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x01, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "idx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x44, 0x42 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ifo", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x44, 0x56, 0x44 }, Offset = 0, Size = 3 }
                }
            },
            {
                "img", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x49, 0x43, 0x54, 0x00, 0x08 }, Offset = 0, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xEB, 0x3C, 0x90, 0x2A }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x43, 0x4D, 0x49 }, Offset = 0, Size = 4 }
                }
            },
            {
                "ind", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x49, 0x44, 0x58 }, Offset = 0, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 }
                }
            },
            {
                "info", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xE3, 0x10, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x7A, 0x62, 0x65, 0x78 }, Offset = 0, Size = 4 }
                }
            },
            {
                "iso", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x44, 0x30, 0x30, 0x31 }, Offset = 0, Size = 5 }
                }
            },
            {
                "ivr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x52, 0x45, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jar", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x5F, 0x27, 0xA8, 0x89 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4A, 0x41, 0x52, 0x43, 0x53, 0x00 }, Offset = 0, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x08, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "jfif", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4A, 0x47, 0x03, 0x0E }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4A, 0x47, 0x04, 0x0E }, Offset = 0, Size = 4 }
                }
            },
            {
                "jnt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x42, 0x2A, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jp2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "jpe", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jpeg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE2 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE3 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jpg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE0 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE1 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xD8, 0xFF, 0xE8 }, Offset = 0, Size = 4 }
                }
            },
            {
                "jtp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x42, 0x2A, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "kgb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4B, 0x47, 0x42, 0x5F, 0x61, 0x72, 0x63, 0x68 }, Offset = 0, Size = 8 }
                }
            },
            {
                "koz", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x44, 0x33, 0x03, 0x00, 0x00, 0x00 }, Offset = 0, Size = 7 }
                }
            },
            {
                "kwd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "lbk", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xC8, 0x00, 0x79, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "lgc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x7B, 0x0D, 0x0A, 0x6F, 0x20 }, Offset = 0, Size = 5 }
                }
            },
            {
                "lgd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x7B, 0x0D, 0x0A, 0x6F, 0x20 }, Offset = 0, Size = 5 }
                }
            },
            {
                "lha", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2D, 0x6C, 0x68 }, Offset = 2, Size = 3 }
                }
            },
            {
                "lib", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A }, Offset = 0, Size = 8 }
                }
            },
            {
                "lit", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x54, 0x4F, 0x4C, 0x49, 0x54, 0x4C, 0x53 }, Offset = 0, Size = 8 }
                }
            },
            {
                "lnk", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x00, 0x00, 0x00, 0x01, 0x14, 0x02, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "log", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2A, 0x2A, 0x2A, 0x20, 0x20, 0x49, 0x6E, 0x73 }, Offset = 0, Size = 9 }
                }
            },
            {
                "lwp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x57, 0x6F, 0x72, 0x64, 0x50, 0x72, 0x6F }, Offset = 0, Size = 7 }
                }
            },
            {
                "lzh", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2D, 0x6C, 0x68 }, Offset = 2, Size = 3 }
                }
            },
            {
                "m4a", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70, 0x4D, 0x34, 0x41 }, Offset = 0, Size = 11 }
                }
            },
            {
                "manifest", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D }, Offset = 0, Size = 14 }
                }
            },
            {
                "mar", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x72, 0x30, 0x00 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x52, 0x43 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x52, 0x31, 0x00 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x72, 0x30, 0x00 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x52, 0x43 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x41, 0x52, 0x31, 0x00 }, Offset = 0, Size = 5 }
                }
            },
            {
                "mdb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x4A, 0x65, 0x74, 0x20, 0x44, 0x42 }, Offset = 0, Size = 19 }
                }
            },
            {
                "mdf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x01, 0x0F, 0x00, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "mdi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x50 }, Offset = 0, Size = 2 }
                }
            },
            {
                "mid", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x54, 0x68, 0x64 }, Offset = 0, Size = 4 }
                }
            },
            {
                "midi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x54, 0x68, 0x64 }, Offset = 0, Size = 4 }
                }
            },
            {
                "mif", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x4D, 0x61, 0x6B, 0x65, 0x72, 0x46, 0x69 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x56, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "mkv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x45, 0xDF, 0xA3, 0x93, 0x42, 0x82, 0x88 }, Offset = 0, Size = 8 }
                }
            },
            {
                "mls", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x49, 0x4C, 0x45, 0x53 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x56, 0x32, 0x31, 0x34 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x56, 0x32, 0x43 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4C, 0x53, 0x57 }, Offset = 0, Size = 4 }
                }
            },
            {
                "mmf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4D, 0x4D, 0x44, 0x00, 0x00 }, Offset = 0, Size = 6 }
                }
            },
            {
                "mny", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x01, 0x00, 0x00, 0x4D, 0x53, 0x49, 0x53, 0x41, 0x4D, 0x20, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65 }, Offset = 0, Size = 19 }
                }
            },
            {
                "mof", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xFE, 0x23, 0x00, 0x6C, 0x00, 0x69, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "mov", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x6D, 0x6F, 0x6F, 0x76 }, Offset = 4, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x66, 0x72, 0x65, 0x65 }, Offset = 4, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x6D, 0x64, 0x61, 0x74 }, Offset = 4, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x77, 0x69, 0x64, 0x65 }, Offset = 4, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x70, 0x6E, 0x6F, 0x74 }, Offset = 4, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6B, 0x69, 0x70 }, Offset = 4, Size = 4 }
                }
            },
            {
                "mp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x0C, 0xED }, Offset = 0, Size = 2 }
                }
            },
            {
                "mp3", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x44, 0x33 }, Offset = 0, Size = 3 }
                }
            },
            {
                "mpg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x01, 0xBA }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x01, 0xB3 }, Offset = 0, Size = 4 }
                }
            },
            {
                "msc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31, 0x2E, 0x30, 0x22, 0x3F, 0x3E, 0x0D, 0x0A, 0x3C, 0x4D, 0x4D, 0x43, 0x5F, 0x43, 0x6F, 0x6E, 0x73, 0x6F, 0x6C, 0x65, 0x46, 0x69, 0x6C, 0x65, 0x20, 0x43, 0x6F, 0x6E, 0x73, 0x6F, 0x6C, 0x65, 0x56, 0x65, 0x72 }, Offset = 0, Size = 56 }
                }
            },
            {
                "msi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x20 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x20 }, Offset = 0, Size = 2 }
                }
            },
            {
                "msv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, Offset = 0, Size = 8 }
                }
            },
            {
                "mtw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "nri", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x0E, 0x4E, 0x65, 0x72, 0x6F, 0x49, 0x53, 0x4F }, Offset = 0, Size = 8 }
                }
            },
            {
                "nsf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x00, 0x00, 0x04, 0x00, 0x00 }, Offset = 0, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x45, 0x53, 0x4D, 0x1A, 0x01 }, Offset = 0, Size = 6 }
                }
            },
            {
                "ntf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x00, 0x00 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4E, 0x49, 0x54, 0x46, 0x30 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x30, 0x31, 0x4F, 0x52, 0x44, 0x4E, 0x41, 0x4E }, Offset = 0, Size = 8 }
                }
            },
            {
                "nvram", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x52, 0x56, 0x4E }, Offset = 0, Size = 4 }
                }
            },
            {
                "obj", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4C, 0x01 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x80 }, Offset = 0, Size = 1 }
                }
            },
            {
                "ocx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "odp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "odt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "oga", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ogg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ogv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ogx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "olb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "one", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xE4, 0x52, 0x5C, 0x7B, 0x8C, 0xD8, 0xA7, 0x4D }, Offset = 0, Size = 8 }
                }
            },
            {
                "opt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x20 }, Offset = 512, Size = 5 }
                }
            },
            {
                "org", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x56, 0x4D, 0x31, 0x30, 0x30 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ott", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "p10", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x64, 0x00, 0x00, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "pak", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1A, 0x0B }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x41, 0x43, 0x4B }, Offset = 0, Size = 4 }
                }
            },
            {
                "pat", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x47, 0x50, 0x41, 0x54 }, Offset = 0, Size = 4 }
                }
            },
            {
                "pax", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x41, 0x58 }, Offset = 0, Size = 3 }
                }
            },
            {
                "pch", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x56, 0x43, 0x50, 0x43, 0x48, 0x30 }, Offset = 0, Size = 6 }
                }
            },
            {
                "pcx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x0A, 0x02, 0x01, 0x01 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x0A, 0x03, 0x01, 0x01 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x0A, 0x05, 0x01, 0x01 }, Offset = 0, Size = 4 }
                }
            },
            {
                "pdb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xAC, 0xED, 0x00, 0x05, 0x73, 0x72, 0x00, 0x12 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x2D, 0x57, 0x20, 0x50, 0x6F, 0x63, 0x6B }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x43, 0x2F, 0x43, 0x2B, 0x2B, 0x20 }, Offset = 0, Size = 16 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x6D, 0x5F }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x73, 0x7A, 0x65, 0x7A }, Offset = 0, Size = 4 }
                }
            },
            {
                "pdf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x25, 0x50, 0x44, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "pf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x11, 0x00, 0x00, 0x00, 0x53, 0x43, 0x43, 0x41 }, Offset = 0, Size = 8 }
                }
            },
            {
                "pfc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4F, 0x4C, 0x56, 0x4D, 0x31, 0x30, 0x30 }, Offset = 0, Size = 8 }
                }
            },
            {
                "pgd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x47, 0x50, 0x64, 0x4D, 0x41, 0x49, 0x4E }, Offset = 0, Size = 8 }
                }
            },
            {
                "pgm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x35, 0x0A }, Offset = 0, Size = 3 }
                }
            },
            {
                "pif", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "pkr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x99, 0x01 }, Offset = 0, Size = 2 }
                }
            },
            {
                "png", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }, Offset = 0, Size = 8 }
                }
            },
            {
                "pps", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ppt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x6E, 0x1E, 0xF0 }, Offset = 512, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x0F, 0x00, 0xE8, 0x03 }, Offset = 512, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xA0, 0x46, 0x1D, 0xF0 }, Offset = 512, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x0E, 0x00, 0x00, 0x00 }, Offset = 512, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x1C, 0x00, 0x00, 0x00 }, Offset = 512, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x43, 0x00, 0x00, 0x00 }, Offset = 512, Size = 8 }
                }
            },
            {
                "pptx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "ppz", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x43, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "prc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x4F, 0x4F, 0x4B, 0x4D, 0x4F, 0x42, 0x49 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x74, 0x42, 0x4D, 0x50, 0x4B, 0x6E, 0x57, 0x72 }, Offset = 60, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x4F, 0x4F, 0x4B, 0x4D, 0x4F, 0x42, 0x49 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x74, 0x42, 0x4D, 0x50, 0x4B, 0x6E, 0x57, 0x72 }, Offset = 60, Size = 8 }
                }
            },
            {
                "psd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x38, 0x42, 0x50, 0x53 }, Offset = 0, Size = 4 }
                }
            },
            {
                "psp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x7E, 0x42, 0x4B, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "pub", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "pwi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x7B, 0x5C, 0x70, 0x77, 0x69 }, Offset = 0, Size = 5 }
                }
            },
            {
                "pwl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xB0, 0x4D, 0x46, 0x43 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xE3, 0x82, 0x85, 0x96 }, Offset = 0, Size = 4 }
                }
            },
            {
                "qbb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x86, 0x00, 0x00, 0x06, 0x00 }, Offset = 0, Size = 6 }
                }
            },
            {
                "qcp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "qdf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xAC, 0x9E, 0xBD, 0x8F, 0x00, 0x00 }, Offset = 0, Size = 6 }
                }
            },
            {
                "qel", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x51, 0x45, 0x4C, 0x20 }, Offset = 92, Size = 4 }
                }
            },
            {
                "qemu", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x51, 0x46, 0x49 }, Offset = 0, Size = 3 }
                }
            },
            {
                "qph", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x03, 0x00, 0x00, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "qsd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "qts", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "qtx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "qxd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x49, 0x49, 0x58, 0x50, 0x52 }, Offset = 0, Size = 7 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x4D, 0x4D, 0x58, 0x50, 0x52 }, Offset = 0, Size = 7 }
                }
            },
            {
                "ra", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x72, 0x61, 0xFD, 0x00 }, Offset = 0, Size = 5 }
                }
            },
            {
                "ram", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x72, 0x74, 0x73, 0x70, 0x3A, 0x2F, 0x2F }, Offset = 0, Size = 7 }
                }
            },
            {
                "rar", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, Offset = 0, Size = 7 }
                }
            },
            {
                "reg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xFE }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x45, 0x47, 0x45, 0x44, 0x49, 0x54 }, Offset = 0, Size = 7 }
                }
            },
            {
                "rgb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x01, 0xDA, 0x01, 0x01, 0x00, 0x03 }, Offset = 0, Size = 6 }
                }
            },
            {
                "rm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x52, 0x4D, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "rmi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "rmvb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x2E, 0x52, 0x4D, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "rpm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xED, 0xAB, 0xEE, 0xDB }, Offset = 0, Size = 4 }
                }
            },
            {
                "rtd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x23, 0x2B, 0x44, 0xA4, 0x43, 0x4D, 0xA5 }, Offset = 0, Size = 8 }
                }
            },
            {
                "rtf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31 }, Offset = 0, Size = 6 }
                }
            },
            {
                "rvt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "sam", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x56, 0x45, 0x52, 0x5D }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x76, 0x65, 0x72, 0x5D }, Offset = 0, Size = 5 }
                }
            },
            {
                "sav", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x24, 0x46, 0x4C, 0x32, 0x40, 0x28, 0x23, 0x29 }, Offset = 0, Size = 8 }
                }
            },
            {
                "scr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "sdr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x4D, 0x41, 0x52, 0x54, 0x44, 0x52, 0x57 }, Offset = 0, Size = 8 }
                }
            },
            {
                "sh3", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x48, 0x48, 0x47, 0x42, 0x31 }, Offset = 0, Size = 5 }
                }
            },
            {
                "shd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x68, 0x49, 0x00, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4B, 0x49, 0x00, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x67, 0x49, 0x00, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x66, 0x49, 0x00, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "shw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x48, 0x4F, 0x57 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sit", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x49, 0x54, 0x21, 0x00 }, Offset = 0, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x53, 0x74, 0x75, 0x66, 0x66, 0x49, 0x74, 0x20 }, Offset = 0, Size = 8 }
                }
            },
            {
                "skf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x07, 0x53, 0x4B, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "skr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x95, 0x00 }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x95, 0x01 }, Offset = 0, Size = 2 }
                }
            },
            {
                "sle", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x43, 0x76 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x3A, 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E }, Offset = 0, Size = 8 }
                }
            },
            {
                "sln", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x56, 0x69, 0x73, 0x75, 0x61, 0x6C }, Offset = 0, Size = 16 }
                }
            },
            {
                "snm", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x1E, 0x84, 0x90, 0x00, 0x00, 0x00, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "snp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x43, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sou", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "spl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x01, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "spo", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "sud", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x45, 0x47, 0x45, 0x44, 0x49, 0x54 }, Offset = 0, Size = 7 }
                }
            },
            {
                "suo", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x04 }, Offset = 512, Size = 5 }
                }
            },
            {
                "swf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x57, 0x53 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x46, 0x57, 0x53 }, Offset = 0, Size = 3 }
                }
            },
            {
                "sxc", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sxd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sxi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sxw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "sys", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0xFF, 0xFF, 0xFF }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x4B, 0x45, 0x59, 0x42, 0x20, 0x20, 0x20 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xE8 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xE9 }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xEB }, Offset = 0, Size = 1 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF }, Offset = 0, Size = 1 }
                }
            },
            {
                "syw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x41, 0x4D, 0x59, 0x4F }, Offset = 0, Size = 4 }
                }
            },
            {
                "tar", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x75, 0x73, 0x74, 0x61, 0x72 }, Offset = 257, Size = 5 }
                }
            },
            {
                "tar.bz2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x5A, 0x68 }, Offset = 0, Size = 3 }
                }
            },
            {
                "tar.z", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1F, 0x9D, 0x90 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x1F, 0xA0 }, Offset = 0, Size = 2 }
                }
            },
            {
                "tb2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x5A, 0x68 }, Offset = 0, Size = 3 }
                }
            },
            {
                "tbz2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x5A, 0x68 }, Offset = 0, Size = 3 }
                }
            },
            {
                "tib", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xB4, 0x6E, 0x68, 0x44 }, Offset = 0, Size = 4 }
                }
            },
            {
                "tif", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x20, 0x49 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x49, 0x2A, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4D, 0x00, 0x2A }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4D, 0x00, 0x2B }, Offset = 0, Size = 4 }
                }
            },
            {
                "tiff", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x20, 0x49 }, Offset = 0, Size = 3 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x49, 0x49, 0x2A, 0x00 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4D, 0x00, 0x2A }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x4D, 0x00, 0x2B }, Offset = 0, Size = 4 }
                }
            },
            {
                "tlb", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x53, 0x46, 0x54, 0x02, 0x00, 0x01, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "tr1", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x01, 0x10 }, Offset = 0, Size = 3 }
                }
            },
            {
                "uce", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x55, 0x43, 0x45, 0x58 }, Offset = 0, Size = 4 }
                }
            },
            {
                "ufa", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x55, 0x46, 0x41, 0xC6, 0xD2, 0xC1 }, Offset = 0, Size = 6 }
                }
            },
            {
                "vbx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "vcd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x45, 0x4E, 0x54, 0x52, 0x59, 0x56, 0x43, 0x44 }, Offset = 0, Size = 8 }
                }
            },
            {
                "vcf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x42, 0x45, 0x47, 0x49, 0x4E, 0x3A, 0x56, 0x43 }, Offset = 0, Size = 8 }
                }
            },
            {
                "vcw", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x5B, 0x4D, 0x53, 0x56, 0x43 }, Offset = 0, Size = 5 }
                }
            },
            {
                "vhd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x63, 0x6F, 0x6E, 0x65, 0x63, 0x74, 0x69, 0x78 }, Offset = 0, Size = 8 }
                }
            },
            {
                "vmdk", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x43, 0x4F, 0x57, 0x44 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x23, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x44 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x4B, 0x44, 0x4D }, Offset = 0, Size = 3 }
                }
            },
            {
                "vob", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x01, 0xBA }, Offset = 0, Size = 4 }
                }
            },
            {
                "vsd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "vxd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A }, Offset = 0, Size = 2 }
                }
            },
            {
                "wab", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x9C, 0xCB, 0xCB, 0x8D, 0x13, 0x75, 0xD2, 0x11 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x81, 0x32, 0x84, 0xC1, 0x85, 0x05, 0xD0, 0x11 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wav", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x52, 0x49, 0x46, 0x46 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wb2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x02, 0x00 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wb3", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3E, 0x00, 0x03, 0x00, 0xFE, 0xFF, 0x09, 0x00, 0x06 }, Offset = 24, Size = 9 }
                }
            },
            {
                "wiz", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wk1", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x02, 0x00, 0x06, 0x04, 0x06, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wk3", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x1A, 0x00, 0x00, 0x10, 0x04, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wk4", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wk5", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wks", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x0E, 0x57, 0x4B, 0x53 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x00, 0x02, 0x00, 0x04, 0x04, 0x05, 0x54 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wma", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wmf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD7, 0xCD, 0xC6, 0x9A }, Offset = 0, Size = 4 }
                }
            },
            {
                "wmv", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wmz", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wp5", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wp6", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wpd", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wpf", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x81, 0xCD, 0xAB }, Offset = 0, Size = 3 }
                }
            },
            {
                "wpg", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wpl", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73, 0x20, 0x4D, 0x65, 0x64, 0x69, 0x61, 0x20, 0x50, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x20, 0x2D, 0x2D, 0x20 }, Offset = 84, Size = 34 }
                }
            },
            {
                "wpp", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xFF, 0x57, 0x50, 0x43 }, Offset = 0, Size = 4 }
                }
            },
            {
                "wps", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "wri", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x31, 0xBE }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x32, 0xBE }, Offset = 0, Size = 2 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xBE, 0x00, 0x00, 0x00, 0xAB }, Offset = 0, Size = 5 }
                }
            },
            {
                "ws", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x1D, 0x7D }, Offset = 0, Size = 2 }
                }
            },
            {
                "ws2", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x57, 0x53, 0x32, 0x30, 0x30, 0x30 }, Offset = 0, Size = 6 }
                }
            },
            {
                "xdr", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C }, Offset = 0, Size = 1 }
                }
            },
            {
                "xla", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 }
                }
            },
            {
                "xls", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, Offset = 0, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x09, 0x08, 0x10, 0x00, 0x00, 0x06, 0x05, 0x00 }, Offset = 512, Size = 8 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x10 }, Offset = 512, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x1F }, Offset = 512, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x22 }, Offset = 512, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x23 }, Offset = 512, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x28 }, Offset = 512, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0xFD, 0xFF, 0xFF, 0xFF, 0x29 }, Offset = 512, Size = 5 }
                }
            },
            {
                "xlsx", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, Offset = 0, Size = 8 }
                }
            },
            {
                "xml", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31, 0x2E, 0x30, 0x22, 0x3F, 0x3E }, Offset = 0, Size = 21 }
                }
            },
            {
                "xpi", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "xps", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 }
                }
            },
            {
                "xpt", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x58, 0x50, 0x43, 0x4F, 0x4D, 0x0A, 0x54, 0x79 }, Offset = 0, Size = 8 }
                }
            },
            {
                "zap", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0xFF, 0xFF }, Offset = 0, Size = 14 }
                }
            },
            {
                "zip", new List<MagicNumberRecord> {
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x4C, 0x49, 0x54, 0x45 }, Offset = 30, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x53, 0x70, 0x58 }, Offset = 526, Size = 5 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x05, 0x06 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x07, 0x08 }, Offset = 0, Size = 4 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x57, 0x69, 0x6E, 0x5A, 0x69, 0x70 }, Offset = 29152, Size = 6 },
                    new MagicNumberRecord(){ Number = new byte[] {  0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x01, 0x00 }, Offset = 0, Size = 8 }
                }
            },
        };
    }
}
