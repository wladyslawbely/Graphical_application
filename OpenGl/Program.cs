using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenGl;
using OpenTK.Windowing.GraphicsLibraryFramework;
using System.IO.Pipes;

namespace OpenGL
{
    class Game : GameWindow
    {
        private ShaderProgram shaderProgram, shaderProgramLamp, shaderProgramCube;
       
        private Functionality functionality;

        private float _rotationAngle;

        private Camera camera;

        private NamedPipeServerStream? server;
        private string? currentcommand;

        public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) :
            base(gameWindowSettings, nativeWindowSettings)
        {
            shaderProgram = new ShaderProgram(@"data\shader\shader_base.vert", @"data\shader\shader_base.frag");
            shaderProgramLamp = new ShaderProgram(@"data\shader\shader_base.vert", @"data\shader\shader_lamp.frag");
            shaderProgramCube = new ShaderProgram(@"data\shader\shader_cube.vert", @"data\shader\shader_cube.frag");
            camera = new Camera(Vector3.UnitZ * 3, Size.X / (float)Size.Y);
            camera.Fov = 90f;
            functionality = new Functionality(shaderProgram, shaderProgramLamp, shaderProgramCube,camera);
        }
        protected override void OnLoad()
        {
            base.OnLoad();
            GL.ClearColor(180 / 255.0f, 255 / 255.0f, 255 / 255.0f, 255 / 255.0f);
            GL.Enable(EnableCap.DepthTest);

            //GL.PolygonMode(MaterialFace.FrontAndBack,PolygonMode.Line) ;
        }


        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Size.X, Size.Y);
            camera.AspectRatio = Size.X / (float)Size.Y;
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            StartListening();
            _rotationAngle += (float)args.Time * 30.0f;
            functionality.UpdateRotationAngle(_rotationAngle);

            if (!IsFocused)
            {
                return;
            }

            var input = KeyboardState;

            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            }

            const float cameraSpeed = 1.5f;
            const float sensitivity = 1.2f;

            if (input.IsKeyDown(Keys.W))
            {
                camera.Position += camera.Front * cameraSpeed * (float)args.Time;
            }

            if (input.IsKeyDown(Keys.S))
            {
                camera.Position -= camera.Front * cameraSpeed * (float)args.Time;
            }
            if (input.IsKeyDown(Keys.A))
            {
                camera.Position -= camera.Right * cameraSpeed * (float)args.Time;
            }
            if (input.IsKeyDown(Keys.D))
            {
                camera.Position += camera.Right * cameraSpeed * (float)args.Time;
            }
            if (input.IsKeyDown(Keys.Space))
            {
                camera.Position += camera.Up * cameraSpeed * (float)args.Time;
            }
            if (input.IsKeyDown(Keys.LeftShift))
            {
                camera.Position -= camera.Up * cameraSpeed * (float)args.Time;
            }

            if (input.IsKeyDown(Keys.Up))
            {
                camera.Pitch += sensitivity;
            }
            if (input.IsKeyDown(Keys.Down))
            {
                camera.Pitch -= sensitivity;
            }
            if (input.IsKeyDown(Keys.Left))
            {
                camera.Yaw -= sensitivity;
            }
            if (input.IsKeyDown(Keys.Right))
            {
                camera.Yaw += sensitivity;
            }
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            if (currentcommand == "cube")
            {
                functionality.DrawVAO();
            }
            if (currentcommand == "pyramid")
            {
                functionality.DrawVAOPyr();
            }
            if (currentcommand == "CUBE")
            {
                functionality.DrawCube();
            }
            functionality.DrawVAOLamp();
            functionality.DrawVAOPol();
            SwapBuffers();
        }


        protected override void OnUnload()
        {
            base.OnUnload();
            functionality.DeleteVAO();
            shaderProgram.DeleteveProgram();
            shaderProgramLamp.DeleteveProgram();
            shaderProgramCube.DeleteveProgram();
        }

        public async Task StartListening()
        {
            server = new NamedPipeServerStream("OpenTK");
            while (true)
            {
                await server.WaitForConnectionAsync();
                using (var reader = new StreamReader(server))
                {
                    currentcommand = reader.ReadLine();
                }
                server.Disconnect();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var gameWindowSettings = new GameWindowSettings()
            {

            };
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(1500, 800),
                APIVersion = new Version(4, 6),
                API = ContextAPI.OpenGL,
                Vsync = VSyncMode.On
            };
            Game game = new Game(gameWindowSettings,nativeWindowSettings);
            game.Run();
        }   
    }
}