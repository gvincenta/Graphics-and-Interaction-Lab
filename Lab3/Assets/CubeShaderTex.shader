//UNITY_SHADER_NO_UPGRADE

Shader "Unlit/CubeShaderTex"
{
    //similar to public vars. 
	Properties
	{
    
        //texture 
        
		_MainTex ("Texture", 2D) = "white" {}//if no image, render whites. 
	}
	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			uniform sampler2D _MainTex;	

			struct vertIn
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct vertOut
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};

			// Implementation of the vertex shader
			vertOut vert(vertIn v)
			{
				vertOut o;
				o.vertex = mul(UNITY_MATRIX_MVP, v.vertex);
				o.uv = v.uv;
				return o;
			}
			
			// Implementation of the fragment shader
			fixed4 frag(vertOut v) : SV_Target
			{
                
				fixed4 col = tex2D(_MainTex, v.uv); // put texture on your coordinates. 
				return col;
			}
			ENDCG
		}
	}
}
