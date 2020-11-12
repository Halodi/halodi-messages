using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "String" defined in "String.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from String.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit String.idl instead.
*
*/
public class StringPubSubType : Halodi.CDR.TopicDataType<std_msgs.msg.String>
{
   public override string Name => "std_msgs::msg::dds_::String_";


   
   public override void serialize(std_msgs.msg.String data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.String data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.String data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.String data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.data.Length + 1;

      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.String data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.data);

   }

   public static void read(std_msgs.msg.String data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data = cdr.read_type_d();	

   }


    public static void Copy(std_msgs.msg.String src, std_msgs.msg.String target)
    {
        target.Set(src);
    }


}


}