using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Float32" defined in "Float32.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Float32.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Float32.idl instead.
*
*/
public class Float32PubSubType : Halodi.CDR.TopicDataType<Float32>
{
   public override string Name => "std_msgs::msg::dds_::Float32_";


   
   public override void serialize(std_msgs.msg.Float32 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Float32 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Float32 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Float32 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Float32 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_5(data.data);

   }

   public static void read(std_msgs.msg.Float32 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_5();
      	

   }


    public static void Copy(std_msgs.msg.Float32 src, std_msgs.msg.Float32 target)
    {
        target.Set(src);
    }


}


}