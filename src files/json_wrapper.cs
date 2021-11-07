using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace onecheatss
{
	// Token: 0x02000012 RID: 18
	public class json_wrapper
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000030AC File Offset: 0x000012AC
		public static bool TGgufMnZHu6oCJZUP04X(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006054 File Offset: 0x00004254
		public json_wrapper(object obj_to_work_with)
		{
			this.1okg8jMjKRx8VLOzz5j4COAZY = obj_to_work_with;
			Type type = this.1okg8jMjKRx8VLOzz5j4COAZY.GetType();
			this.IAHCHHub3BloBsbm7zaaCOAZY = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.TGgufMnZHu6oCJZUP04X(type);
			if (flag)
			{
				throw new Exception(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String("dGhlIG9iamVjdCB7MH0gaXNuJ3QgYSBzZXJpYWxpemFibGU=")), this.1okg8jMjKRx8VLOzz5j4COAZY));
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000060C0 File Offset: 0x000042C0
		public object vL0MDM2pdbmBQFRUIpAV(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.IAHCHHub3BloBsbm7zaaCOAZY.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000030D0 File Offset: 0x000012D0
		public T vmcQkI6Mluj8BV9Ig3q3<T>(string json)
		{
			return (T)((object)this.vL0MDM2pdbmBQFRUIpAV(json));
		}

		// Token: 0x0400002D RID: 45
		private DataContractJsonSerializer IAHCHHub3BloBsbm7zaaCOAZY;

		// Token: 0x0400002E RID: 46
		private object 1okg8jMjKRx8VLOzz5j4COAZY;
	}
}
