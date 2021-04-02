using Unity.Mathematics;

namespace Pickgliss.Helper
{
    public static class MathHelper
    {
        // converts signed range [-1,+1] to to unsigned [0,1]
        public const float Tau = 6.28318530717958647693f;
        public const float TauInverse = 1.0f / Tau;
        public const float TauHalf = Tau / 2.0f;
        public const float TauQuarter = Tau / 4.0f;
        public const float Pi = TauHalf;
        public const float TwoPI = Tau;
        public const float HalfPI = math.PI / 2.0f;
        public const float Sqrt2 = 1.41421356237309504880f;
        public const float Sqrt2_Inverse = 1.0f / Sqrt2;
        public const float Sqrt3 = 1.73205080756887729353f;
        public const float Sqrt3_Inverse = 1.0f / Sqrt3;
        // converts unsigned range [-1,+1] to to signed [0,+1]
        public static float toUnsignedRange(float value) { return value * 0.5f + 0.5f; }
        public static float2 toUnsignedRange(float2 value) { return value * 0.5f + 0.5f; }
        public static float3 toUnsignedRange(float3 value) { return value * 0.5f + 0.5f; }
        public static float4 toUnsignedRange(float4 value) { return value * 0.5f + 0.5f; }

        // converts unsigned range [0,1] to to signed [-1,+1]
        public static float toSignedRange(float value) { return (value - 0.5f) * 2.0f; }
        public static float2 toSignedRange(float2 value) { return (value - 0.5f) * 2.0f; }
        public static float3 toSignedRange(float3 value) { return (value - 0.5f) * 2.0f; }
        public static float4 toSignedRange(float4 value) { return (value - 0.5f) * 2.0f; }
    }
}