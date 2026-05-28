using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Internal;
using Microsoft.Extensions.AI;

namespace DevExpress.AI.Demos.Modules.SemanticSearch {
    public class CachingEmbeddingGenerator : IEmbeddingGenerator<string, Embedding<float>> {
        private readonly IEmbeddingGenerator<string, Embedding<float>> _generator;
        private readonly Dictionary<string, Embedding<float>> _cache;

        public CachingEmbeddingGenerator(IEmbeddingGenerator<string, Embedding<float>> generator) {
            _generator = generator;
            _cache = LoadCache() ?? new Dictionary<string, Embedding<float>>();
        }

        public async Task<GeneratedEmbeddings<Embedding<float>>> GenerateAsync(IEnumerable<string> values,
            EmbeddingGenerationOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken)) {
            var newValues = values.Except(_cache.Keys).ToList();
            UsageDetails usageDetails = null;
            if(newValues.Count > 0) {
                var newEmbeddings = await _generator.GenerateAsync(newValues, options, cancellationToken).ConfigureAwait(false);
                usageDetails = newEmbeddings.Usage;
                for(var i = 0; i < newValues.Count; i++) {
                    _cache[newValues[i]] = newEmbeddings[i];
                }
            }

            var embeddings = new List<Embedding<float>>();
            foreach(var value in values) {
                embeddings.Add(_cache.TryGetValue(value, out var embedding) ? embedding : null);
            }

            return new GeneratedEmbeddings<Embedding<float>>(embeddings) { Usage = usageDetails };
        }

        public object GetService(Type serviceType, object serviceKey = null) {
            return _generator.GetService(serviceType, serviceKey);
        }

        public void Dispose() {
            _generator.Dispose();
        }

        private Dictionary<string, Embedding<float>> LoadCache() {
            //load from here - \Demos.Win\AIDemos\Data\MovieVectors.json
            var jsonFile = DevAVDataDirectoryHelper.GetFile("MovieVectors.json");
            if(!string.IsNullOrEmpty(jsonFile) && File.Exists(jsonFile)) {
                var jsonContent = File.ReadAllText(jsonFile);
                return JsonSerializer.Deserialize<Dictionary<string, Embedding<float>>>(jsonContent);
            }
            return null;
        }
    }
}
