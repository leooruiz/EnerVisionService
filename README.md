# EnerVisionService – API de Falhas de Energia

API RESTful criada como parte do projeto **EnerVision**, uma solução comunitária para registro e resposta a falhas elétricas causadas por eventos climáticos.

## 📦 Estrutura

O projeto segue arquitetura em camadas:

- `EnerVisionService.API` – Camada de apresentação (controllers, Swagger, Startup)
- `EnerVisionService.Application` – Lógica de aplicação (serviços)
- `EnerVisionService.Domain` – Entidades e interfaces
- `EnerVisionService.Infrastructure` – Implementações dos repositórios

## 🔧 Tecnologias

- ASP.NET Core 8
- Swagger (Swashbuckle)
- C#
- .NET CLI

## ▶️ Como rodar localmente

1. Clone o projeto:
   ```bash
   git clone https://github.com/seuusuario/EnerVisionService.git