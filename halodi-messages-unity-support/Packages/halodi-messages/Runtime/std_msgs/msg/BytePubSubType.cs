using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Byte" defined in "Byte.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Byte.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Byte.idl instead.
*
*/
public class BytePubSubType : Halodi.CDR.TopicDataType<std_msgs.msg.Byte>
{
   public override string Name => "std_msgs::msg::dds_::Byte_";


   
   public override void serialize(std_msgs.msg.Byte data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Byte data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Byte data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Byte data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Byte data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.data);

   }

   public static void read(std_msgs.msg.Byte data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_9();
      	

   }


    public static void Copy(std_msgs.msg.Byte src, std_msgs.msg.Byte target)
    {
        target.Set(src);
    }


}


}