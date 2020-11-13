using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "TransformStamped" defined in "TransformStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TransformStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TransformStamped.idl instead.
*
*/
public class TransformStampedPubSubType : Halodi.CDR.TopicDataType<TransformStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::TransformStamped_";


   
   public override void serialize(geometry_msgs.msg.TransformStamped data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.TransformStamped data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.TransformStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.TransformStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.child_frame_id.Length + 1;

      current_alignment += geometry_msgs.msg.TransformPubSubType.getCdrSerializedSize(data.transform, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.TransformStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_d(data.child_frame_id);

      geometry_msgs.msg.TransformPubSubType.write(data.transform, cdr);

   }

   public static void read(geometry_msgs.msg.TransformStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.child_frame_id = cdr.read_type_d();	
      data.transform = geometry_msgs.msg.TransformPubSubType.Create();
      geometry_msgs.msg.TransformPubSubType.read(data.transform, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.TransformStamped src, geometry_msgs.msg.TransformStamped target)
    {
        target.Set(src);
    }


}


}