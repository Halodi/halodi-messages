using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "HandCommand" defined in "HandCommand.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from HandCommand.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit HandCommand.idl instead.
*
*/
public class HandCommandPubSubType : Halodi.CDR.TopicDataType<HandCommand>
{
   public override string Name => "halodi_msgs::msg::dds_::HandCommand_";


   
   public override void serialize(halodi_msgs.msg.HandCommand data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.HandCommand data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.HandCommand data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.HandCommand data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);


      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_6(data.closure);

      cdr.write_type_6(data.velocity);

      cdr.write_type_6(data.force);

   }

   public static void read(halodi_msgs.msg.HandCommand data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.closure=cdr.read_type_6();
      	
      data.velocity=cdr.read_type_6();
      	
      data.force=cdr.read_type_6();
      	

   }


    public static void Copy(halodi_msgs.msg.HandCommand src, halodi_msgs.msg.HandCommand target)
    {
        target.Set(src);
    }


}


}