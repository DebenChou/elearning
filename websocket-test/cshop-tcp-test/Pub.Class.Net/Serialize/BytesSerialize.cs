using System;

#if NETCLIENT
namespace Pub.Class.NetClient {
#else
namespace Pub.Class.Net {
#endif
    /// <summary>
    /// ���л��ͷ����л�
    /// 
    /// �޸ļ�¼
    ///     2013.02.12 �汾��1.0 livexy ��������
    /// 
    /// </summary>
    public class BytesSerialize {
        private static IBytesSerialize bytesSerialize = null;
        private static readonly object lockHelper = new object();
        /// <summary>
        /// ʹ���ⲿ���
        /// </summary>
        public static void Use<T>() where T : IBytesSerialize, new() {
            lock (lockHelper) {
                bytesSerialize = new T();
            }
        }
        ///<summary>
        /// ���л�
        ///</summary>
        public static byte[] ToBytes<T>(T o) {
            try {
                if (bytesSerialize == null) Use<BinaryFormatterSerialize>();
                return bytesSerialize.Serialize(o);
            } catch (Exception ex) {
                throw ex;
            }
        }
        ///<summary>
        /// �����л�
        ///</summary>
        public static T FromBytes<T>(byte[] data) {
            try {
                if (bytesSerialize == null) Use<BinaryFormatterSerialize>();
                return bytesSerialize.Deserialize<T>(data);
            } catch (Exception ex) {
                throw ex;
            }
        }
        /// <summary>
        /// ע������
        /// </summary>
        /// <param name="types"></param>
        public static void RegisterTypes(params Type[] types) {
            try {
                if (bytesSerialize == null) Use<BinaryFormatterSerialize>();
                bytesSerialize.RegisterTypes(types);
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
