using System;
using System.Collections.Generic;

class GraphColoring
{
    static void Main()
    {
        // Ma trận đồ thị
        string[] matrix = {
            "01110000",
            "10101000",
            "11011100",
            "10100110",
            "01100101",
            "00111011",
            "00010101",
            "00001110"
        };

        // Các đỉnh
        char[] vertices = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'Z' };

        int numVertices = vertices.Length;
        int[] colors = new int[numVertices]; // Mảng màu

        colors[0] = 1; // Gán màu 1 cho đỉnh đầu tiên (A)

        for (int i = 1; i < numVertices; i++)
        {
            HashSet<int> availableColors = new HashSet<int>(); // Tập các màu có thể sử dụng

            // Kiểm tra các đỉnh kề của đỉnh hiện tại
            for (int j = 0; j < i; j++)
            {
                if (matrix[i][j] == '1' && colors[j] != 0)
                {
                    availableColors.Add(colors[j]); // Thêm màu của đỉnh kề vào tập các màu
                }
            }

            // Tìm màu nhỏ nhất còn lại trong tập các màu
            int color = 1;
            while (availableColors.Contains(color))
            {
                color++;
            }

            colors[i] = color; // Gán màu cho đỉnh hiện tại
        }

        // In kết quả
        for (int i = 0; i < numVertices; i++)
        {
            Console.WriteLine("Đinh {0} duoc tô màu {1}", vertices[i], colors[i]);
        }
    }
}