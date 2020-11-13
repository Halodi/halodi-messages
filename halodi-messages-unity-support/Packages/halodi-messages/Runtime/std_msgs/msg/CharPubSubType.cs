using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "Char" defined in "Char.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from Char.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit Char.idl instead.
*
*/
public class CharPubSubType : Halodi.CDR.TopicDataType<Char>
{
   public override string Name => "std_msgs::msg::dds_::Char_";


   
   public override void serialize(std_msgs.msg.Char data, MemoryStream stream)
   {
   	  using(BinaryWriter writer = new BinaryWriter(stream))
   	  {
   	  	  Halodi.CDR.CDRSerializer cdr = new Halodi.CDR.CDRSerializer(writer);
   	  	  write(data, cdr); 
   	  }
   }

   
   public override void deserialize(MemoryStream stream, std_msgs.msg.Char data)
   {
   	   using(BinaryReader reader = new BinaryReader(stream))
   	   {
   	   		Halodi.CDR.CDRDeserializer cdr = new Halodi.CDR.CDRDeserializer(reader);
   	   		read(data, cdr); 
   	   }
   }

   public static int getCdrSerializedSize(std_msgs.msg.Char data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.Char data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.Char data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_8(data.data);

   }

   public static void read(std_msgs.msg.Char data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data=cdr.read_type_8();
      	

   }


    public static void Copy(std_msgs.msg.Char src, std_msgs.msg.Char target)
    {
        target.Set(src);
    }


}


}