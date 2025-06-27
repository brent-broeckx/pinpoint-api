# 🛠️ Pinpoint API

The **Pinpoint API** is the backend service powering the Pinpoint bug reporting and feedback platform. Built with ASP.NET Core (.NET 8), it provides endpoints for receiving contextual bug reports, managing integrations with Azure DevOps, Microsoft Graph, and OpenAI, and supporting all core features of the Pinpoint SDK and webapp.

---

## ✨ Features

- **Receive Story and Bug Reports**: Accepts annotated story / bug reports, screenshots, logs, and DOM metadata from the Pinpoint SDK/webapp.
- **Azure DevOps Integration**: Create awork items (bugs, stories) in Azure DevOps via REST API.
- **User Tagging**: (Planned) Lookup and tag users via Microsoft Graph API.
- **AI Assistance**: (Planned) Connect to OpenAI/Azure OpenAI to generate bug descriptions and repro steps.
- **Teams Notifications**: (Planned) Notify teams via Microsoft Teams webhooks or Graph API.
- **Extensible**: Designed for future integrations (Jira, Slack, Discord, etc.).

---

## 🚀 Quick Start (NOT YET RELEASED)

### 1. Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Azure DevOps account (for integration)

### 2. Build & Run

```powershell
# Navigate to the API project directory
cd api/pinpoint-api/pinpoint-api.AppHost

# Restore dependencies
 dotnet restore

# Build the project
 dotnet build

# Run the API
 dotnet run
```

The API will start on the configured port (see `appsettings.json`).

---

## 🗂️ Project Structure

```
api/pinpoint-api/
  pinpoint-api.sln           # Solution file
  pinpoint-api.AppHost/      # Main API host (entry point)
    Program.cs               # Startup and configuration
    appsettings.json         # Configuration (endpoints, keys, etc.)
    Controllers/             # API controllers (bug reports, integrations)
    Properties/
  pinpoint-api.ServiceDefaults/ # Shared service configuration/extensions
```

---

## 🛠️ API Endpoints (Examples)

- `POST /api/bugreport` — Submit a new bug report (with screenshot, logs, DOM info)
- `GET /api/projects` — List accessible Azure DevOps projects (requires auth)
- `POST /api/workitem` — Create a new work item in Azure DevOps
- `POST /api/notify` — (Planned) Send notification to Teams

> See controller source code for full endpoint list and request/response schemas.

---

## 🔒 Authentication & Security
- **Current**: No global authentication required (MVP phase)
- **Planned**: OAuth2/MSAL integration for user authentication and Azure DevOps access
- **Token Strategy**: Access tokens passed via `X-Integration-Token-*` headers

---

## 🧩 Integrations
- **Azure DevOps**: Create and update work items, attach screenshots/logs
- **Microsoft Graph**: Lookup users, send Teams notifications (future)
- **OpenAI/Azure OpenAI**: Generate bug descriptions and repro steps (future)
- **Jira, Slack, Discord**: Planned for future phases

---

## 🗺️ Roadmap Highlights
- [x] .NET 8 Web API setup
- [ ] Bug report endpoint
- [ ] Azure DevOps integration (work item creation)
- [ ] Entra ID authentication
- [ ] Teams notification
- [ ] AI-powered bug description/repro steps