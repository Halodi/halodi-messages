using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Bool" defined in "Bool.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Bool.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Bool.idl instead.
*
*/
public class BoolPubSubType : Halodi.CDR.TopicDataType<Bool>
{
   public override string Name => "std_msgs::msg::dds_::Bool_";


   
   public override void serialize(std_msgs.msg.Bool data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Bool data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Bool data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Bool data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Bool data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_7(data.data);

   }

   public static void read(std_msgs.msg.Bool data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_7();
      	

   }


    public static void Copy(std_msgs.msg.Bool src, std_msgs.msg.Bool target)
    {
        target.Set(src);
    }


}


}