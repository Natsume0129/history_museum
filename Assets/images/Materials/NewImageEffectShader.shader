Shader "Hidden/NewImageEffectShader"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _BumpMap("Bump Map",2D) = "bump" {}
        _Magnitude("Magnitude",Range(0,1)) = 0.05
        _Color("Color",Color) = (1,1,1,1)
    }
        SubShader
        {
            //这里首先要设置为透明的渲染队列Transparent，玻璃不需要投影所以设置IgnoreProjector
            Tags {"Queue" = "Transparent" "IgnoreProjector" = "True" "RenderType" = "Opaque"}

            ZWrite ON
            Lighting Off
            Cull Off
            Blend One Zero
            Fog{Mode Off}
            //截图整个屏幕画面
             GrabPass {"_GrapTexture"}
             Pass
             {
                 CGPROGRAM
                 #pragma vertex vert
                 #pragma fragment frag


                 #include "UnityCG.cginc"

                 struct appdata
                 {
                    float4 vertex : POSITION;
                     float4 color : COLOR;
                     float2 texcoord : TEXCOORD0;
                 };


                 struct v2f
                 {
                     float4 vertex : POSITION;
                     fixed4 color : COLOR;
                     float2 texcoord : TEXCOORD0;

                     float4 uvgrab : TEXCOORD1;
                 };


                 sampler2D _MainTex;
                 sampler2D _BumpMap;
                 float _Magnitude;
                 fixed4 _Color;
                 float4 _MainTex_ST;
                 sampler2D _GrapTexture;

                 v2f vert(appdata v)
                 {
                     v2f o;
                     o.vertex = UnityObjectToClipPos(v.vertex);
                     o.color = v.color;
                     o.texcoord = v.texcoord;
                     o.uvgrab = ComputeGrabScreenPos(o.vertex);
                     return o;
                 }

                 fixed4 frag(v2f i) : SV_Target
                 {
                     half4 mainColour = tex2D(_MainTex, i.texcoord);

                     half4 bump = tex2D(_BumpMap, i.texcoord);
                     half2 distortion = UnpackNormal(bump).rg;

                     i.uvgrab.xy += distortion * _Magnitude;
                     fixed4 col = tex2Dproj(_GrapTexture, UNITY_PROJ_COORD(i.uvgrab));
                     return col * mainColour * _Color;
                 }
                 ENDCG
             }
        }
}
