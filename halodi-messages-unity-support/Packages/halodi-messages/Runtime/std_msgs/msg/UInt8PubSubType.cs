using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt8" defined in "UInt8.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt8.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt8.idl instead.
*
*/
public class UInt8PubSubType : Halodi.CDR.TopicDataType<std_msgs.msg.UInt8>
{
   public override string Name => "std_msgs::msg::dds_::UInt8_";


   
   public override void serialize(std_msgs.msg.UInt8 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.UInt8 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt8 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt8 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt8 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.data);

   }

   public static void read(std_msgs.msg.UInt8 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_9();
      	

   }


    public static void Copy(std_msgs.msg.UInt8 src, std_msgs.msg.UInt8 target)
    {
        target.Set(src);
    }


}


}