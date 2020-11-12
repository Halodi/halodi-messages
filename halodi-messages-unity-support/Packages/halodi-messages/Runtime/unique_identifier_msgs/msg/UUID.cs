using System.Text;
namespace unique_identifier_msgs.msg
{


/**
       * A universally unique identifier (UUID).
       * 
       * http://en.wikipedia.org/wiki/Universally_unique_identifier
       * http://tools.ietf.org/html/rfc4122.html
       */
[System.Serializable]
public class UUID
{
   public readonly byte[] uuid = new byte[16];

   public void Set(UUID other)
   {
      for(int i1 = 0; i1 < 16; ++i1)
      {
            uuid[i1] = other.uuid[i1];

      }
   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("UUID {");
      builder.Append("uuid=");
      builder.Append(Halodi.CDR.CDRCommon.ArrayToString(",", this.uuid));
      builder.Append("}");
      return builder.ToString();
   }
}


}