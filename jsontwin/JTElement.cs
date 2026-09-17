using System.Text.Json.Serialization;

namespace jsontwin
{
    [JsonConverter(typeof(JTConverter))]
    public abstract class JTElement
    {
        #region init

        private protected JTElement()
        {
            
        }

        #endregion
        
        #region fields

        private 

        private protected JTElement()
        {
            
        }

        #endregion
    }
}
