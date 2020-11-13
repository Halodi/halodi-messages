using System.IO;
namespace diagnostic_msgs.msg
{

/**
* 
* Topic data type of the struct "KeyValue" defined in "KeyValue.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from KeyValue.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit KeyValue.idl instead.
*
*/
public class KeyValuePubSubType : Halodi.CDR.TopicDataType<KeyValue>
{
   public override string Name => "diagnostic_msgs::msg::dds_::KeyValue_";


   
   public override void serialize(diagnostic_msgs.msg.KeyValue data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, diagnostic_msgs.msg.KeyValue data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.KeyValue data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(diagnostic_msgs.msg.KeyValue data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.key.Length + 1;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.value.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(diagnostic_msgs.msg.KeyValue data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.key);

      cdr.write_type_d(data.value);

   }

   public static void read(diagnostic_msgs.msg.KeyValue data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.key = cdr.read_type_d();	
      data.value = cdr.read_type_d();	

   }


    public static void Copy(diagnostic_msgs.msg.KeyValue src, diagnostic_msgs.msg.KeyValue target)
    {
        target.Set(src);
    }


}


}