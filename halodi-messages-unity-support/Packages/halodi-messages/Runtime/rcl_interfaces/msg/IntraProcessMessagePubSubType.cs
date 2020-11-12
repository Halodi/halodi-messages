using System.IO;
namespace rcl_interfaces.msg
{

/**
* 
* Topic data type of the struct "IntraProcessMessage" defined in "IntraProcessMessage.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from IntraProcessMessage.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit IntraProcessMessage.idl instead.
*
*/
public class IntraProcessMessagePubSubType : Halodi.CDR.TopicDataType<rcl_interfaces.msg.IntraProcessMessage>
{
   public override string Name => "rcl_interfaces::msg::dds_::IntraProcessMessage_";


   
   public override void serialize(rcl_interfaces.msg.IntraProcessMessage data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, rcl_interfaces.msg.IntraProcessMessage data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.IntraProcessMessage data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(rcl_interfaces.msg.IntraProcessMessage data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(rcl_interfaces.msg.IntraProcessMessage data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_12(data.publisher_id);

      cdr.write_type_12(data.message_sequence);

   }

   public static void read(rcl_interfaces.msg.IntraProcessMessage data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.publisher_id=cdr.read_type_12();
      	
      data.message_sequence=cdr.read_type_12();
      	

   }


    public static void Copy(rcl_interfaces.msg.IntraProcessMessage src, rcl_interfaces.msg.IntraProcessMessage target)
    {
        target.Set(src);
    }


}


}