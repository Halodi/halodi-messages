using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Int16" defined in "Int16.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Int16.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Int16.idl instead.
*
*/
public class Int16PubSubType : Halodi.CDR.TopicDataType<Int16>
{
   public override string Name => "std_msgs::msg::dds_::Int16_";


   
   public override void serialize(std_msgs.msg.Int16 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Int16 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Int16 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Int16 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 2 + Halodi.CDR.CDRCommon.alignment(current_alignment, 2);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Int16 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_1(data.data);

   }

   public static void read(std_msgs.msg.Int16 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_1();
      	

   }


    public static void Copy(std_msgs.msg.Int16 src, std_msgs.msg.Int16 target)
    {
        target.Set(src);
    }


}


}