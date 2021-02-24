using System;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Library.Api.Helpers {
    public static class HashFactory {
        /// <summary>获取对象的哈希值</summary>
        /// <remarks>首先将对象进行序列化，并将结果转换为byte[]类型，然后使用MD5散列算法得到最终的结果。</remarks>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string GetHash(object entity) {
            string result;
            var json = JsonConvert.SerializeObject(entity);
            var bytes = Encoding.UTF8.GetBytes(json);
            
            using var hasher = MD5.Create();
            var hash = hasher.ComputeHash(bytes);
            result = BitConverter.ToString(hash);
            result = result.Replace("-", "");

            return result;
        }
    }
}