using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Int64" defined in "Int64.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Int64.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Int64.idl instead.
*
*/
public class Int64PubSubType : Halodi.CDR.TopicDataType<Int64>
{
   public override string Name => "std_msgs::msg::dds_::Int64_";


   
   public override void serialize(std_msgs.msg.Int64 data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Int64 data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Int64 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Int64 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 8 + Halodi.CDR.CDRCommon.alignment(current_alignment, 8);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Int64 data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_11(data.data);

   }

   public static void read(std_msgs.msg.Int64 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_11();
      	

   }


    public static void Copy(std_msgs.msg.Int64 src, std_msgs.msg.Int64 target)
    {
        target.Set(src);
    }


}


}