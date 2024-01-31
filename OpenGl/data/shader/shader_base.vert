#version 460

layout(location = 0) in vec3 aPosition;
layout(location = 1) in vec4 aColor;
layout(location = 2) in vec3 aNormal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

out vec4 inColorF;

out vec3 Normal;
out vec3 FragPos;

void main()
{
    gl_Position = projection * view * model * vec4(aPosition, 1.0);
    Normal = aNormal * mat3(transpose(inverse(model)));
    FragPos = vec3(model * vec4(aPosition,1.0));
}



