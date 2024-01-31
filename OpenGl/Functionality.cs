using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using OpenGl;
using StbImageSharp;

namespace OpenGL
{
    public class Functionality
    {
        float[] vert_pol = new float[]
        {
            -10.0f, -2.0f, 10.0f,
             10.0f, -2.0f, 10.0f,
             10.0f, -2.0f, -10.0f,
            -10.0f, -2.0f, -10.0f,
        };

        uint[] indices_pol = {

             0, 1, 3,
             1, 2, 3
        };

        float[] normals_pol = new float[]
        {
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
        };

        float[] vert_cube = new float[]
        {
            // Передняя грань
            -0.5f, -0.5f,  0.5f,
            0.5f, -0.5f,  0.5f,
            -0.5f,  0.5f,  0.5f,
            0.5f,  0.5f,  0.5f,   

            // Задняя грань
            -0.5f, -0.5f, -0.5f,
            0.5f, -0.5f, -0.5f,
            -0.5f,  0.5f, -0.5f,
            0.5f,  0.5f, -0.5f,  

            // Верхняя грань
            -0.5f,  0.5f,  0.5f,
            0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f, -0.5f,
            0.5f,  0.5f, -0.5f,  

            // Нижняя грань
            -0.5f, -0.5f,  0.5f,
            0.5f, -0.5f,  0.5f,
            -0.5f, -0.5f, -0.5f,
            0.5f, -0.5f, -0.5f,  

            // Левая грань
            -0.5f, -0.5f,  0.5f,
            -0.5f, -0.5f, -0.5f,
            -0.5f,  0.5f,  0.5f,
            -0.5f,  0.5f, -0.5f,   
            
            // Правая грань
            0.5f, -0.5f,  0.5f,
            0.5f, -0.5f, -0.5f,
            0.5f,  0.5f,  0.5f,
            0.5f,  0.5f, -0.5f,
        };




        float[] normals = new float[]
        {
            // Передняя грань
            0.0f, 0.0f, -1.0f,
            0.0f, 0.0f, -1.0f,
            0.0f, 0.0f, -1.0f,
            0.0f, 0.0f, -1.0f,

            // Задняя грань
            0.0f, 0.0f, 1.0f,
            0.0f, 0.0f, 1.0f,
            0.0f, 0.0f, 1.0f,
            0.0f, 0.0f, 1.0f,

            // Верхняя грань
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 1.0f, 0.0f,

            // Нижняя грань
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f,

            // Левая грань
            -1.0f, 0.0f, 0.0f,
            -1.0f, 0.0f, 0.0f,
            -1.0f, 0.0f, 0.0f,
            -1.0f, 0.0f, 0.0f,

            // Правая грань
            1.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f,
            1.0f, 0.0f, 0.0f
        };

        uint[] index = new uint[]
        {
            // Передняя грань
            0, 1, 2,
            2, 1, 3,

            // Задняя грань
            4, 5, 6,
            6, 5, 7,

            // Верхняя грань
            8, 9, 10,
            10, 9, 11,

            // Нижняя грань
            12, 13, 14,
            14, 13, 15,

            // Левая грань
            16, 17, 18,
            18, 17, 19,

            // Правая грань
            20, 21, 22,
            22, 21, 23
        };


        float[] vertices = new float[]
         {
            // Передняя грань
            0.0f, 1.0f, 0.0f,
            -1.0f, -1.0f, -1.0f,
            1.0f, -1.0f, -1.0f,

            // Правая грань
            0.0f, 1.0f, 0.0f,
            1.0f, -1.0f, -1.0f,
            1.0f, -1.0f, 1.0f,

            // Задняя грань
            0.0f, 1.0f, 0.0f,
            1.0f, -1.0f, 1.0f,
            -1.0f, -1.0f, 1.0f,

            // Левая грань
            0.0f, 1.0f, 0.0f,
            -1.0f, -1.0f, 1.0f,
            -1.0f, -1.0f, -1.0f,

            // Нижняя грань
            -1.0f, -1.0f, -1.0f,
            -1.0f, -1.0f, 1.0f,
            1.0f, -1.0f, 1.0f,
            1.0f, -1.0f, -1.0f
         };

        float[] normalsss = new float[]
        {
            // Передняя грань
            0.0f, 0.4472f, 0.8944f,
            0.0f, 0.4472f, 0.8944f,
            0.0f, 0.4472f, 0.8944f,

            // Правая грань
            0.8944f, 0.4472f, 0.0f,
            0.8944f, 0.4472f, 0.0f,
            0.8944f, 0.4472f, 0.0f,

            // Задняя грань
            0.0f, 0.4472f, -0.8944f,
            0.0f, 0.4472f, -0.8944f,
            0.0f, 0.4472f, -0.8944f,

            // Левая грань
            -0.8944f, 0.4472f, 0.0f,
            -0.8944f, 0.4472f, 0.0f,
            -0.8944f, 0.4472f, 0.0f,

            // Нижняя грань
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f,
            0.0f, -1.0f, 0.0f
        };

        uint[] indices = new uint[]
        {
            // Передняя грань
            0, 1, 2,

            // Правая грань
            3, 4, 5,

            // Задняя грань
            6, 7, 8,

            // Левая грань
            9, 10, 11,

            // Нижняя грань
            12, 13, 14,
            14, 15, 12
        };

        static List<string> faces = new List<string>
        {
            "Resources/front.jpg",
            "Resources/back.jpg",
            "Resources/bottom.jpg",
            "Resources/top.jpg",
            "Resources/left.jpg",
            "Resources/right.jpg",
        };



        private int vaoId = 0, vaoIdLamp = 0, vaoPol = 0, vaoPyr = 0, cubemapTexture = 0;
        private ShaderProgram shaderProgram, shaderProgramLamp, shaderProgramCube;
        private Matrix4 modelMatrix;
        private Matrix4 viewMatrix;
        private Matrix4 projectionMatrix;

        private float _rotationAngle ;

        private Camera camera;

        private readonly Vector3 _lightPos = new Vector3(3.2f, 3.0f, 0.0f);

        public Functionality(ShaderProgram shaderProgram, ShaderProgram shaderProgramLamp, ShaderProgram shaderProgramCube,Camera camera)
        {
            this.shaderProgram = shaderProgram;
            this.shaderProgramLamp = shaderProgramLamp;
            this.shaderProgramCube = shaderProgramCube;
            this.camera = camera;

            vaoId = CreateVAO();
            vaoIdLamp = CreateVAOLight();
            vaoPol = CreateVAOPol();
            vaoPyr = CreateVAOPyr();
            cubemapTexture = LoadCubemap(faces);
        }
        public void UpdateRotationAngle(float rotationAngle)
        {
            _rotationAngle = rotationAngle;
        }
        public int CreateVBO(float[] data)
        {
            int vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, data.Length * sizeof(float), data, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            return vbo;
        }

        public int CreateEBO(uint[] data)
        {
            int ebo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, data.Length * sizeof(uint), data, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
            return ebo;
        }

        public int CreateVAOLight()
        {
            int vaoLamp = GL.GenVertexArray();
            GL.BindVertexArray(vaoLamp);
            int vbo = CreateVBO(vert_cube);
            int ebo = CreateEBO(index);

            int vertexLocation = shaderProgramLamp.GetAttribProg("aPosition");
            GL.EnableVertexAttribArray(vertexLocation);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);

            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DisableVertexAttribArray(vertexLocation);
            return vaoLamp;
        }

        public static int LoadCubemap(List<string> faces)
        {
            GL.GenTextures(1, out int textureID);
            GL.BindTexture(TextureTarget.TextureCubeMap, textureID);

            for (int i = 0; i < faces.Count; i++)
            {
                ImageResult image = ImageResult.FromStream(File.OpenRead(faces[i]), ColorComponents.RedGreenBlueAlpha);
                GL.TexImage2D(TextureTarget.TextureCubeMapPositiveX + i, 0, PixelInternalFormat.Rgba, image.Width, image.Height, 0, PixelFormat.Rgba, PixelType.UnsignedByte, image.Data);

            }
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToEdge);
            GL.TexParameter(TextureTarget.TextureCubeMap, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToEdge);

            return textureID;
        }

        public int CreateVAOPol()
        {
            int vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            int vbo = CreateVBO(vert_pol);
            int ebo = CreateEBO(indices_pol);
            int normal = CreateVBO(normals_pol);

            int vertexLocation = shaderProgram.GetAttribProg("aPosition");
            int NormalArray = shaderProgram.GetAttribProg("aNormal");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.EnableVertexAttribArray(NormalArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);

            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, normal);
            GL.VertexAttribPointer(NormalArray, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DisableVertexAttribArray(vertexLocation);
            GL.DisableVertexAttribArray(NormalArray);
            return vao;
        }

        public int CreateVAOPyr()
        {
            int vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            int vbo = CreateVBO(vertices);
            int ebo = CreateEBO(indices);
            int normal = CreateVBO(normalsss);

            int vertexLocation = shaderProgram.GetAttribProg("aPosition");
            int NormalArray = shaderProgram.GetAttribProg("aNormal");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.EnableVertexAttribArray(NormalArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);

            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, normal);
            GL.VertexAttribPointer(NormalArray, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DisableVertexAttribArray(vertexLocation);
            GL.DisableVertexAttribArray(NormalArray);
            return vao;
        }

        public int CreateVAO()
        {
            int vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);
            int vboVC = CreateVBO(vert_cube);
            int ebo = CreateEBO(index);
            int normal = CreateVBO(normals);


            int VertexArray = shaderProgram.GetAttribProg("aPosition");
            int NormalArrayCube = shaderProgramCube.GetAttribProg("aNormal");
            int NormalArray = shaderProgram.GetAttribProg("aNormal");
            GL.EnableVertexAttribArray(VertexArray);
            GL.EnableVertexAttribArray(NormalArray);
            GL.EnableVertexAttribArray(NormalArrayCube);

            GL.BindBuffer(BufferTarget.ArrayBuffer, vboVC);
            GL.VertexAttribPointer(VertexArray, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, normal);
            GL.VertexAttribPointer(NormalArray, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindBuffer(BufferTarget.ArrayBuffer, normal);
            GL.VertexAttribPointer(NormalArrayCube, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);

            GL.BindBuffer(BufferTarget.ElementArrayBuffer, ebo);

            GL.BindVertexArray(0);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            GL.DisableVertexAttribArray(NormalArray);
            GL.DisableVertexAttribArray(NormalArrayCube);
            GL.DisableVertexAttribArray(VertexArray);

            return vao;
        }

        public void DrawVAO()
        {
            shaderProgram.ActiveProgram();
            GL.BindVertexArray(vaoId);
            shaderProgram.SetUniform("objectColor", new Vector3(1.0f, 0.0f, 0.3f));
            shaderProgram.SetUniform("lightColor", new Vector3(1.0f, 1.0f, 1.0f));
            shaderProgram.SetUniform("lightPos", _lightPos);

            Vector3 viewPos = camera.Position;
            shaderProgram.SetUniform("viewPos", viewPos);

            modelMatrix = Matrix4.Identity * Matrix4.CreateRotationY((float)MathHelper.DegreesToRadians(_rotationAngle));
            viewMatrix = camera.GetViewMatrix();
            projectionMatrix = camera.GetProjectionMatrix();

            int modelLocation = GL.GetUniformLocation(shaderProgram.program, "model");
            GL.UniformMatrix4(modelLocation, false, ref modelMatrix);

            int viewLocation = GL.GetUniformLocation(shaderProgram.program, "view");
            GL.UniformMatrix4(viewLocation, false, ref viewMatrix);

            int projectionLocation = GL.GetUniformLocation(shaderProgram.program, "projection");
            GL.UniformMatrix4(projectionLocation, false, ref projectionMatrix);

            GL.DrawElements(PrimitiveType.Triangles, index.Length, DrawElementsType.UnsignedInt, 0);
            shaderProgram.DeactiveProgram();
        }

        public void DrawCube()
        {
            shaderProgramCube.ActiveProgram();
            GL.BindVertexArray(vaoId);

            GL.ActiveTexture(TextureUnit.Texture0);
            GL.BindTexture(TextureTarget.TextureCubeMap, cubemapTexture);

            shaderProgram.SetUniform("objectColor", new Vector3(1.0f, 1.0f, 1.0f));
            shaderProgram.SetUniform("lightColor", new Vector3(1.0f, 1.0f, 1.0f));
            shaderProgram.SetUniform("lightPos", _lightPos);

            Vector3 viewPos = camera.Position;
            shaderProgram.SetUniform("viewPos", viewPos);
            modelMatrix = Matrix4.Identity;
            viewMatrix = camera.GetViewMatrix();
            projectionMatrix = camera.GetProjectionMatrix();

            int modelLocation = GL.GetUniformLocation(shaderProgramCube.program, "model");
            GL.UniformMatrix4(modelLocation, false, ref modelMatrix);

            int viewLocation = GL.GetUniformLocation(shaderProgramCube.program, "view");
            GL.UniformMatrix4(viewLocation, false, ref viewMatrix);

            int projectionLocation = GL.GetUniformLocation(shaderProgramCube.program, "projection");
            GL.UniformMatrix4(projectionLocation, false, ref projectionMatrix);

            int skyboxLocation = GL.GetUniformLocation(shaderProgramCube.program, "cubemap");
            GL.Uniform1(skyboxLocation, 0);

            GL.DrawElements(PrimitiveType.Triangles, index.Length, DrawElementsType.UnsignedInt, 0);
            shaderProgramCube.DeactiveProgram();
        }


        public void DrawVAOPyr()
        {
            shaderProgram.ActiveProgram();
            GL.BindVertexArray(vaoPyr);
            shaderProgram.SetUniform("objectColor", new Vector3(0.5f, 0.7f, 0.3f));
            shaderProgram.SetUniform("lightColor", new Vector3(1.0f, 1.0f, 1.0f));
            shaderProgram.SetUniform("lightPos", _lightPos);

            Vector3 viewPos = camera.Position;
            shaderProgram.SetUniform("viewPos", viewPos);

            modelMatrix = Matrix4.Identity * Matrix4.CreateRotationY((float)MathHelper.DegreesToRadians(_rotationAngle));
            viewMatrix = camera.GetViewMatrix();
            projectionMatrix = camera.GetProjectionMatrix();

            int modelLocation = GL.GetUniformLocation(shaderProgram.program, "model");
            GL.UniformMatrix4(modelLocation, false, ref modelMatrix);

            int viewLocation = GL.GetUniformLocation(shaderProgram.program, "view");
            GL.UniformMatrix4(viewLocation, false, ref viewMatrix);

            int projectionLocation = GL.GetUniformLocation(shaderProgram.program, "projection");
            GL.UniformMatrix4(projectionLocation, false, ref projectionMatrix);

            GL.DrawElements(PrimitiveType.Triangles, index.Length, DrawElementsType.UnsignedInt, 0);
            shaderProgram.DeactiveProgram();
        }
        public void DrawVAOLamp()
        {
            shaderProgramLamp.ActiveProgram();
            GL.BindVertexArray(vaoIdLamp);

            Matrix4 lampMatrix = Matrix4.CreateScale(0.2f);
            lampMatrix *= Matrix4.CreateTranslation(_lightPos);

            int modelLocation = GL.GetUniformLocation(shaderProgramLamp.program, "model");
            GL.UniformMatrix4(modelLocation, false, ref lampMatrix);        

            int viewLocation = GL.GetUniformLocation(shaderProgramLamp.program, "view");
            GL.UniformMatrix4(viewLocation, false, ref viewMatrix);

            int projectionLocation = GL.GetUniformLocation(shaderProgramLamp.program, "projection");
            GL.UniformMatrix4(projectionLocation, false, ref projectionMatrix);

            GL.DrawElements(PrimitiveType.Triangles, index.Length, DrawElementsType.UnsignedInt, 0);
            shaderProgramLamp.DeactiveProgram();
        }
        public void DrawVAOPol()
        {
            shaderProgram.ActiveProgram();
            GL.BindVertexArray(vaoPol);
            shaderProgram.SetUniform("objectColor", new Vector3(1.0f, 0.9f, 0.9f));
            shaderProgram.SetUniform("lightColor", new Vector3(1.0f, 1.0f, 1.0f));
            shaderProgram.SetUniform("lightPos", _lightPos);

            Vector3 viewPos = camera.Position;
            shaderProgram.SetUniform("viewPos", viewPos);

            Matrix4 floorMatrix = Matrix4.CreateScale(1.0f);
            floorMatrix *= Matrix4.CreateTranslation(new Vector3(0.0f, -1.0f, 0.0f));

            viewMatrix = camera.GetViewMatrix();
            projectionMatrix = camera.GetProjectionMatrix();

            int modelLocation = GL.GetUniformLocation(shaderProgram.program, "model");
            GL.UniformMatrix4(modelLocation, false, ref floorMatrix);

            int viewLocation = GL.GetUniformLocation(shaderProgram.program, "view");
            GL.UniformMatrix4(viewLocation, false, ref viewMatrix);

            int projectionLocation = GL.GetUniformLocation(shaderProgram.program, "projection");
            GL.UniformMatrix4(projectionLocation, false, ref projectionMatrix);

            GL.DrawElements(PrimitiveType.Triangles, index.Length, DrawElementsType.UnsignedInt, 0);
            shaderProgram.DeactiveProgram();
        }

        public void DeleteVAO()
        {
            GL.BindVertexArray(0);
            GL.DeleteVertexArray(vaoId);
            GL.DeleteVertexArray(vaoIdLamp);
            GL.DeleteVertexArray(vaoPol);
            GL.DeleteVertexArray(vaoPyr);
        }
        
    }
}