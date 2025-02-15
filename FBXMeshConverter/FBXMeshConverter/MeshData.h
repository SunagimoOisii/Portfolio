#pragma once

#include <vector>
#include <string>

#include<DirectXMath.h>
using namespace DirectX;

struct Vertex
{
	XMFLOAT3 pos;
	XMFLOAT2 uv;
};

//法線対応の頂点構造体
struct VertexNormal
{
	XMFLOAT3 pos;
	XMFLOAT2 uv;
	XMFLOAT3 normal;
};

struct MeshData
{
	std::vector<VertexNormal> vertices;
	std::vector<unsigned short> indices;
	std::wstring textureFileName;
};