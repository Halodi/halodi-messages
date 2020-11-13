using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "PointStamped" defined in "PointStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PointStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PointStamped.idl instead.
*
*/
public class PointStampedPubSubType : Halodi.CDR.TopicDataType<PointStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::PointStamped_";


   
   public override void serialize(geometry_msgs.msg.PointStamped data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.PointStamped data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PointStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.PointStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.PointPubSubType.getCdrSerializedSize(data.point, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.PointStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.PointPubSubType.write(data.point, cdr);

   }

   public static void read(geometry_msgs.msg.PointStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.point = geometry_msgs.msg.PointPubSubType.Create();
      geometry_msgs.msg.PointPubSubType.read(data.point, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.PointStamped src, geometry_msgs.msg.PointStamped target)
    {
        target.Set(src);
    }


}


}