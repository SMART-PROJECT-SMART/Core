using System.Security.Cryptography;
using System.Text;

namespace Core.Common.Helpers
{
    public static class MissionIdHashUtility
    {
        public static double ToHash(string? missionId)
        {
            if (string.IsNullOrEmpty(missionId))
                return 0;

            byte[] hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(missionId));
            ulong hashValue = BitConverter.ToUInt64(hashBytes, 0);

            return (double)hashValue;
        }
    }
}
