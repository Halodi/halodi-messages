using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "UInt64" defined in "UInt64.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UInt64.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UInt64.idl instead.
*
*/
public class UInt64PubSubType : Halodi.CDR.TopicDataType<std_msgs.msg.UInt64>
{
   public override string Name => "std_msgs::msg::dds_::UInt64_";


   
   public override void serialize(std_msgs.msg.UInt64 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.UInt64 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt64 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.UInt64 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.UInt64 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_12(data.data);

   }

   public static void read(std_msgs.msg.UInt64 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_12();
      	

   }


    public static void Copy(std_msgs.msg.UInt64 src, std_msgs.msg.UInt64 target)
    {
        target.Set(src);
    }


}


}