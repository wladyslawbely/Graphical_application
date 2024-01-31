using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace OpenGl
{
    public class ShaderProgram
    {
        private int vertexShader = 0;
        private int fragmentShader = 0;
        public int program { get; set; }
        
        public ShaderProgram(string vertexFile, string fragmentFile) 
        {
            program = 0;
            vertexShader = CreateShader(ShaderType.VertexShader, vertexFile);
            fragmentShader = CreateShader(ShaderType.FragmentShader, fragmentFile);

            program = GL.CreateProgram();
            GL.AttachShader(program, vertexShader);
            GL.AttachShader(program, fragmentShader);

            GL.LinkProgram(program);
            GL.GetProgram(program, GetProgramParameterName.LinkStatus, out var code);
            if(code != (int)All.True)
            {
                var infolog = GL.GetProgramInfoLog(program);
                throw new Exception($"Ошибка линк шейдерной программы {program} \n\n{infolog}");
            }

            DeleteShader(vertexShader);
            DeleteShader(fragmentShader);  
        }

        public void ActiveProgram() => GL.UseProgram(program);

        public void DeactiveProgram() => GL.UseProgram(0);

        public void DeleteveProgram() => GL.DeleteProgram(program);

        private int CreateShader(ShaderType shaderType, string shaderFile)
        {
            string shaderStr = File.ReadAllText(shaderFile);
            int shaderID = GL.CreateShader(shaderType);
            GL.ShaderSource(shaderID,shaderStr);
            GL.CompileShader(shaderID);

            GL.GetShader(shaderID, ShaderParameter.CompileStatus, out var code);
            if(code != (int)All.True)
            {
                var infoLog = GL.GetShaderInfoLog(shaderID);
                throw new Exception($"Ошибка компиляции шейдера{shaderID}\n\n{infoLog}");
            }

            return shaderID;
        }

        public void SetUniform(string name, Vector3 value)
        {
            int location = GL.GetUniformLocation(program, name);
            GL.Uniform3(location, value);
        }

        public void SetUniform1(string name, int value)
        {
            int location = GL.GetUniformLocation(program, name);
            GL.Uniform1(location, value);
        }

        public int GetAttribProg(string name) => GL.GetAttribLocation(program,name);

        private void DeleteShader(int shader)
        {
            GL.DetachShader(program, shader);
            GL.DeleteShader(shader);
        }
    }
}
