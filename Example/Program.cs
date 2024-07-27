﻿using ImGuiNET;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System;
using Zenseless.OpenTK.GUI;

using GameWindow window = new(GameWindowSettings.Default,
    new NativeWindowSettings { APIVersion = new Version(3, 2) });
Console.WriteLine("Running on OpenGL API v" + window.APIVersion);

//DebugOutputGL debugOutput = new();
//debugOutput.DebugEvent += (_, args) => Console.WriteLine(args.Message);
using ImGuiFacade gui = new(window);
gui.LoadFontDroidSans(12 * gui.WindowScale);


window.KeyDown += args =>
{
    if (Keys.Escape == args.Key) window.Close();
};

string input = "hallo";
Vector3 color3 = new(1f, 1f, 1f);
Vector4 color4 = new(1f, 1f, 1f, 1f);
/*var triangles = Helper.CreateRandomTriangles(100);
using Buffer buffer = new();
buffer.Set(triangles);
using VertexArray vertexArray = new();
vertexArray.BindAttribute(0, buffer, 2, Vector2.SizeInBytes, VertexAttribType.Float);*/



window.RenderFrame += args =>
{
    GL.ClearColor(new Color4(0, 32, 48, 255));
    GL.Clear(ClearBufferMask.ColorBufferBit);

    //vertexArray.Bind();
    //GL.DrawArrays(PrimitiveType.Triangles, 0, triangles.Length); // draw with vertex array data
};

window.RenderFrame += args =>
{
    ImGui.NewFrame(); // call each frame before any ImGui.* calls
    ImGui.ShowDemoWindow();

    ImGui.Begin("Style");
    ImGui.ShowStyleEditor();
    ImGui.End();

    ImGui.Begin("user");
    InputUI();

    ImGuiIOPtr io = ImGui.GetIO();

    ImGui.SliderFloat("Font scale", ref io.FontGlobalScale, 0.5f, 4f, "%.1f");

    ImGui.InputText("text", ref input, 255);
    ImGuiHelper.ColorEdit(nameof(color3), ref color3);
    ImGuiHelper.SliderFloat(nameof(color3), ref color3);
    ImGuiHelper.ColorEdit(nameof(color4), ref color4);
    ImGuiHelper.SliderFloat(nameof(color4), ref color4);
    for (int i = 0; i < 3; ++i)
    {
        ImGui.Button("testbutton" + i);
    }

    ImGui.End();
    gui.Render(window.FramebufferSize);
};
window.RenderFrame += _ => window.SwapBuffers();
window.Resize += (_) => GL.Viewport(0, 0, window.FramebufferSize.X, window.FramebufferSize.Y);

window.Run();

static void InputUI()
{
    if (ImGui.IsMouseDown(ImGuiMouseButton.Left))
    {
        ImGui.Text("Left Mouse down");
    }

    if (ImGui.IsMouseDown(ImGuiMouseButton.Right))
    {
        ImGui.Text("Right Mouse down");
    }

    var io = ImGui.GetIO();
    //io.FontGlobalScale += 0.1f * io.MouseWheel;

    ImGui.Text($"{nameof(io.MousePos)}:{io.MousePos}");
}