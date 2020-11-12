using System.IO;
namespace tf2_msgs.msg
{

/**
* 
* Topic data type of the struct "TF2Error" defined in "TF2Error.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from TF2Error.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit TF2Error.idl instead.
*
*/
public class TF2ErrorPubSubType : Halodi.CDR.TopicDataType<tf2_msgs.msg.TF2Error>
{
   public override string Name => "tf2_msgs::msg::dds_::TF2Error_";


   
   public override void serialize(tf2_msgs.msg.TF2Error data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, tf2_msgs.msg.TF2Error data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(tf2_msgs.msg.TF2Error data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(tf2_msgs.msg.TF2Error data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.error_string.Length + 1;


      return current_alignment - initial_alignment;
   }

   public static void write(tf2_msgs.msg.TF2Error data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_9(data.error);

      cdr.write_type_d(data.error_string);

   }

   public static void read(tf2_msgs.msg.TF2Error data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.error=cdr.read_type_9();
      	
      data.error_string = cdr.read_type_d();	

   }


    public static void Copy(tf2_msgs.msg.TF2Error src, tf2_msgs.msg.TF2Error target)
    {
        target.Set(src);
    }


}


}