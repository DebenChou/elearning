using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

#if NETCLIENT
namespace Pub.Class.NetClient {
#else 
namespace Pub.Class.Net {
#endif
    /// <summary>
    /// ʹ��BinaryFormatter���л��ͷ����л�
    /// 
    /// �޸ļ�¼
    ///     2011.07.11 �汾��1.0 livexy ��������
    /// 
    /// <code>
    /// <example>
    /// User u1 = new User() { UserID = 1000, Name = "�ܻ���" };
    /// var serialize = new BinarySerializeString();
    /// string s = serialize.Serialize(u1);
    /// serialize.Deserialize&lt;User>(s);
    /// </example>
    /// </code>
    /// </summary>
    public class BinaryFormatterSerialize : IBytesSerialize {
        public void RegisterTypes(params Type[] types) { }
        /// <summary>
        /// BinaryFormatter���л�
        /// </summary>
        /// <param name="o">����</param>
        /// <returns>�ֽ�����</returns>
        public byte[] Serialize<T>(T o) {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream()) {
                formatter.Serialize(ms, o);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// BinaryFormatter�����л�
        /// </summary>
        /// <typeparam name="T">��������</typeparam>
        /// <param name="data">�ֽ�����</param>
        /// <returns>����</returns>
        public T Deserialize<T>(byte[] data) {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data)) return (T)formatter.Deserialize(ms);
        }
    }
}
