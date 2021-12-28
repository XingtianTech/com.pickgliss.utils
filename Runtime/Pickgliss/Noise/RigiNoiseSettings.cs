using System;
using Pickgliss.Seed;
using UnityEngine;

namespace Pickgliss.Noise
{
	[Serializable]
	public class RidgeNoiseSettings : NoiseSettings
	{
		public float power = 2;
		public float gain = 1;
		public float peakSmoothing = 0;

		public override void SetComputeValues(ComputeShader cs, PRNG prng, string varSuffix)
		{
			SetComputeValues(cs, prng, varSuffix, scale, elevation, power);
		}

		// Set values using custom scale and elevation
		public override void SetComputeValues(ComputeShader cs, PRNG prng, string varSuffix, float scale,
			float elevation, float power)
		{
			Vector3 seededOffset = new Vector3(prng.Value(), prng.Value(), prng.Value()) * prng.Value() * 10000;

			float[] noiseParams =
			{
				// [0]
				seededOffset.x + offset.x,
				seededOffset.y + offset.y,
				seededOffset.z + offset.z,
				numLayers,
				// [1]
				persistence,
				lacunarity,
				scale,
				elevation,
				// [2]
				power,
				gain,
				verticalShift,
				peakSmoothing
			};

			cs.SetFloats(Prefix + varSuffix, noiseParams);
		}
	}
}