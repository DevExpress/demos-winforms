#If NET
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DevExpress.AI.Demos.Agents;
using DevExpress.AI.Demos.Agents.Weather;
using Microsoft.Agents.AI;
using Microsoft.Agents.AI.Hosting;
using Microsoft.Agents.AI.Hosting.AGUI.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.DependencyInjection;

namespace DevExpress.AI.Demos.Services {
    /// <summary>
    /// Self-hosts a minimal ASP.NET Core Kestrel server that exposes an AG-UI
    /// endpoint for the Weather Agent in the WinForms process.
    /// </summary>
    public sealed class AGUIHost : IAsyncDisposable, IDisposable {
        WebApplication app;
        string baseUrl;

        AGUIHost() { }

        public string BaseUrl => baseUrl;

        public static async Task<AGUIHost> StartAsync(AgentFactory agentFactory, WeatherAgentTools weatherTools) {
            var host = new AGUIHost();

            var builder = WebApplication.CreateBuilder();
            builder.Services.AddAGUI();
            builder.AddAIAgent("WeatherAgent", (sp, key) => {
                return agentFactory.CreateWeatherAgent(weatherTools.GetWeatherTool(), key);
            });
            builder.WebHost.UseUrls("http://127.0.0.1:0");

            host.app = builder.Build();
            host.app.MapAGUI("/api/weather-agent",
                host.app.Services.GetRequiredKeyedService<AIAgent>("WeatherAgent"));

            await host.app.StartAsync().ConfigureAwait(false);

            var server = host.app.Services.GetRequiredService<IServer>();
            var addressesFeature = server.Features.Get<IServerAddressesFeature>();
            host.baseUrl = addressesFeature?.Addresses.FirstOrDefault()?.TrimEnd('/') ?? "http://localhost:5099";

            return host;
        }

        public string GetWeatherAgentEndpoint() => $"{baseUrl}/api/weather-agent";

        private bool _disposed;
        public void Dispose() {
            if(_disposed) return;
            (app as IDisposable)?.Dispose();
            _disposed = true;
        }
        public async ValueTask DisposeAsync() {
            if(_disposed) return;
            if(app is not null)
                await app.DisposeAsync().ConfigureAwait(false);
            _disposed = true;
        }
    }
}
#End If
