using System.IO;
namespace halodi_msgs.msg
{

/**
* 
* Topic data type of the struct "ReferenceFrameName" defined in "ReferenceFrameName.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from ReferenceFrameName.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit ReferenceFrameName.idl instead.
*
*/
public class ReferenceFrameNamePubSubType : Halodi.CDR.TopicDataType<ReferenceFrameName>
{
   public override string Name => "halodi_msgs::msg::dds_::ReferenceFrameName_";


   
   public override void serialize(halodi_msgs.msg.ReferenceFrameName data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, halodi_msgs.msg.ReferenceFrameName data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ReferenceFrameName data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(halodi_msgs.msg.ReferenceFrameName data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(halodi_msgs.msg.ReferenceFrameName data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_2(data.frame_id);

   }

   public static void read(halodi_msgs.msg.ReferenceFrameName data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.frame_id=cdr.read_type_2();
      	

   }


    public static void Copy(halodi_msgs.msg.ReferenceFrameName src, halodi_msgs.msg.ReferenceFrameName target)
    {
        target.Set(src);
    }


}


}