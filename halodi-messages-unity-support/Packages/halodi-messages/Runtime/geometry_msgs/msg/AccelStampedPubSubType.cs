using System.IO;
namespace geometry_msgs.msg
{

/**
* 
* Topic data type of the struct "AccelStamped" defined in "AccelStamped.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from AccelStamped.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit AccelStamped.idl instead.
*
*/
public class AccelStampedPubSubType : Halodi.CDR.TopicDataType<AccelStamped>
{
   public override string Name => "geometry_msgs::msg::dds_::AccelStamped_";


   
   public override void serialize(geometry_msgs.msg.AccelStamped data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, geometry_msgs.msg.AccelStamped data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.AccelStamped data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(geometry_msgs.msg.AccelStamped data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += geometry_msgs.msg.AccelPubSubType.getCdrSerializedSize(data.accel, current_alignment);


      return current_alignment - initial_alignment;
   }

   public static void write(geometry_msgs.msg.AccelStamped data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      geometry_msgs.msg.AccelPubSubType.write(data.accel, cdr);

   }

   public static void read(geometry_msgs.msg.AccelStamped data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.accel = geometry_msgs.msg.AccelPubSubType.Create();
      geometry_msgs.msg.AccelPubSubType.read(data.accel, cdr);
      	

   }


    public static void Copy(geometry_msgs.msg.AccelStamped src, geometry_msgs.msg.AccelStamped target)
    {
        target.Set(src);
    }


}


}