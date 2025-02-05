﻿/* 구조체 */
Point3D p3d1;
p3d1.X = 10;
p3d1.Y = 20;
p3d1.Z = 40;

Console.WriteLine(p3d1.ToString()); // 10, 20, 40

Point3D p3d2 = new Point3D(100, 200, 300);
Point3D p3d3 = p3d2; // 깊은 복사
p3d3.Z = 400;

Console.WriteLine(p3d2.ToString()); // 100, 200, 300
Console.WriteLine(p3d3.ToString()); // 100, 200, 400

struct Point3D
{
	public int X;
	public int Y;
	public int Z;

	public Point3D(int X, int Y, int Z)
	{
		this.X = X;
		this.Y = Y;
		this.Z = Z;
	}

	public override string ToString()
	{
		return string.Format($"{X}, {Y}, {Z}");
	}
}
