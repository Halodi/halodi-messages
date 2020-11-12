using System.Text;
namespace sensor_msgs.msg
{


[System.Serializable]
public class PointField
{
   /**
          * This message holds the description of one point entry in the
          * PointCloud2 message format.
          */
   public const byte INT8 = (byte) 1;
   public const byte UINT8 = (byte) 2;
   public const byte INT16 = (byte) 3;
   public const byte UINT16 = (byte) 4;
   public const byte INT32 = (byte) 5;
   public const byte UINT32 = (byte) 6;
   public const byte FLOAT32 = (byte) 7;
   public const byte FLOAT64 = (byte) 8;
   /**
            * Name of field
            */
   public string name;
   /**
            * Offset from start of point struct
            */
   public uint offset;
   /**
            * Datatype enumeration, see above
            */
   public byte datatype;
   /**
            * How many elements in the field
            */
   public uint count;


   public void Set(PointField other)
   {
      name = other.name;

      offset = other.offset;

      datatype = other.datatype;

      count = other.count;

   }


   public override string ToString()
   {
   
      StringBuilder builder = new StringBuilder();

      builder.Append("PointField {");
      builder.Append("name=");
      builder.Append(this.name);      builder.Append(", ");
      builder.Append("offset=");
      builder.Append(this.offset);      builder.Append(", ");
      builder.Append("datatype=");
      builder.Append(this.datatype);      builder.Append(", ");
      builder.Append("count=");
      builder.Append(this.count);
      builder.Append("}");
      return builder.ToString();
   }
}


}