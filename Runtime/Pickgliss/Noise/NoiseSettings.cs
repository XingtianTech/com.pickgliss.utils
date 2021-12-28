using System;
using Pickgliss.Seed;
using UnityEngine;

namespace Pickgliss.Noise
{
	[Serializable]
	public class NoiseSettings
	{
		public const string Prefix = "noise_params_";
		public int numLayers = 4;
		public float lacunarity = 2;
		public float persistence = 0.5f;
		public float scale = 1;
		public float elevation = 1;
		public float verticalShift = 0;
		public Vector3 offset;

		public virtual void SetComputeValues(ComputeShader cs, PRNG prng, string varSuffix)
		{
			SetComputeValues(cs, prng, varSuffix, scale, elevation, persistence);
		}

		// Set values using custom scale and elevation
		public virtual void SetComputeValues(ComputeShader cs, PRNG prng, string varSuffix, float scale,
			float elevation)
		{
			SetComputeValues(cs, prng, varSuffix, scale, elevation, persistence);
		}

		// Set values using custom scale and elevation
		public virtual void SetComputeValues(ComputeShader cs, PRNG prng, string varSuffix, float scale,
			float elevation, float persistence)
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
				verticalShift
			};

			cs.SetFloats(Prefix + varSuffix, noiseParams);
		}
	}
}