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


	public override void Serialize(std_msgs.msg.Char data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.Char data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.Char data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.Char src, std_msgs.msg.Char target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.Char src, std_msgs.msg.Char target)
    {
    	Copy(src, target);
    }


}


}