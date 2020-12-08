using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Header" defined in "Header.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Header.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Header.idl instead.
*
*/
public class HeaderPubSubType : Halodi.CDR.TopicDataType<Header>
{
   public override string Name => "std_msgs::msg::dds_::Header_";


   
   public override void serialize(std_msgs.msg.Header data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Header data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Header data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Header data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += builtin_interfaces.msg.TimePubSubType.getCdrSerializedSize(data.stamp, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.frame_id.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Header data, Halodi.CDR.CDRSerializer cdr)
   {
      builtin_interfaces.msg.TimePubSubType.write(data.stamp, cdr);

      cdr.write_type_d(data.frame_id);

   }

   public static void read(std_msgs.msg.Header data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.stamp = builtin_interfaces.msg.TimePubSubType.Create();
      builtin_interfaces.msg.TimePubSubType.read(data.stamp, cdr);
      	
      data.frame_id = cdr.read_type_d();	

   }


    public static void Copy(std_msgs.msg.Header src, std_msgs.msg.Header target)
    {
        target.Set(src);
    }


}


}