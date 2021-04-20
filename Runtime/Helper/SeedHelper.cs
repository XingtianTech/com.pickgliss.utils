
using Unity.Mathematics;

namespace Pickgliss.VoxelLevel
{
    public static class SeedHelper
    {
        public unsafe static string Uint4ToString(uint4 value)
        {
            var chars = stackalloc char[32];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    uint cur = value[i];
                    cur >>= (j * 4);
                    cur &= 0xF;
                    chars[i * 8 + j] = k_HexToLiteral[cur];
                }
            }

            return new string(chars, 0, 32);
        }

        public unsafe static uint4 HashStringToUint4(string value)
        {
            var result = new uint4();
            fixed(char* ptr = value)
            {
                result = StringToHash(ptr, value.Length);
            }
            return result;
        }

        static unsafe uint4 StringToHash(char* guidString, int length)
        {
            if (length != k_GUIDStringLength)
                return default;

            // Convert every hex char into an int [0...16]
            var hex = stackalloc int[k_GUIDStringLength];
            for (int i = 0; i < k_GUIDStringLength; i++)
            {
                int intValue = guidString[i];
                if (intValue < 0 || intValue > 255)
                    return default;

                hex[i] = k_LiteralToHex[intValue];
            }

            uint4 value = default;
            for (int i = 0; i < 4; i++)
            {
                uint cur = 0;
                for (int j = 7; j >= 0; j--)
                {
                    int curHex = hex[i * 8 + j];
                    if (curHex == -1)
                        return default;

                    cur |= (uint)(curHex << (j * 4));
                }
                value[i] = cur;
            }
            return value;
        }
        static readonly char[] k_HexToLiteral = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        const int k_GUIDStringLength = 32;
        static readonly sbyte[] k_LiteralToHex =
        {
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            -1, -1, -1, -1, -1, -1, -1,
            10, 11, 12, 13, 14, 15,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            10, 11, 12, 13, 14, 15,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1
        };
    }
}