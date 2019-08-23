//UNITY_SHADER_NO_UPGRADE

Shader "Unlit/CubeShader"
{
	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			struct vertIn
			{
				float4 vertex : POSITION;
                
                
                float4 color : COLOR; 
                
                
                
			};

			struct vertOut
			{
				float4 vertex : SV_POSITION;
               float4 color : COLOR; 

                
			};

			// Implementation of the vertex shader
			vertOut vert(vertIn v)
			{
				vertOut o;

				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
                
                //get colors from cubeScript
                o.color = v.color;
				return o;
			}
			
			// Implementation of the fragment shader
			fixed4 frag(vertOut v) : SV_Target
			{
                // will override the colors you've defined in CubeScript.cs
				//return float4(1.0f, 1.0f, 0.0f, 1.0f);
                
                //get colors from cubeScript
                return v.color;
                
			}
			ENDCG
		}
	}
}
