sampler spriteBeach : register(s0);
sampler colorImage : register(s1);
float uTime;
float scrollSpeed;

float4 PixShader(float2 coords : TEXCOORD0) : COLOR0
{
    float4 fontColor = tex2D(spriteBeach, coords);
    if (!any(fontColor))
    {
        return fontColor;
    }
    
    float2 scrollUV = coords + float2(frac(uTime * scrollSpeed), 0.0);
    float2 wrappedUV = frac(scrollUV);
    return tex2D(colorImage, wrappedUV);
}

technique Technique1
{
    pass
    {
        PixelShader = compile ps_2_0 PixShader();
    }
}