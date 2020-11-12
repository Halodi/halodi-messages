using System.IO;
namespace unique_identifier_msgs.msg
{

/**
* 
* Topic data type of the struct "UUID" defined in "UUID.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from UUID.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit UUID.idl instead.
*
*/
public class UUIDPubSubType : Halodi.CDR.TopicDataType<unique_identifier_msgs.msg.UUID>
{
   public override string Name => "unique_identifier_msgs::msg::dds_::UUID_";


   
   public override void serialize(unique_identifier_msgs.msg.UUID data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, unique_identifier_msgs.msg.UUID data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(unique_identifier_msgs.msg.UUID data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(unique_identifier_msgs.msg.UUID data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += ((16) * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);
      return current_alignment - initial_alignment;
   }

   public static void write(unique_identifier_msgs.msg.UUID data, Halodi.CDR.CDRSerializer cdr)
   {
      for(int i0 = 0; i0 < 16; ++i0)
      {
        	cdr.write_type_9(data.uuid[i0]);	
      }
   }

   public static void read(unique_identifier_msgs.msg.UUID data, Halodi.CDR.CDRDeserializer cdr)
   {
      for(int i0 = 0; i0 < 16; ++i0)
      {
        	data.uuid[i0] = cdr.read_type_9();
        	
      }
      	

   }


    public static void Copy(unique_identifier_msgs.msg.UUID src, unique_identifier_msgs.msg.UUID target)
    {
        target.Set(src);
    }


}


}