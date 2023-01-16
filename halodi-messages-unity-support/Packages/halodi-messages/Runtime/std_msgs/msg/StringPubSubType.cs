using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "String" defined in "String.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from String.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit String.idl instead.
*
*/
public class StringPubSubType : Halodi.CDR.TopicDataType<String>
{
   public override string Name => "std_msgs::msg::dds_::String_";


   public static int getCdrSerializedSize(std_msgs.msg.String data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.String data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4) + data.data.Length + 1;

      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.String data, Halodi.CDR.CDRSerializer cdr)
   {
      cdr.write_type_d(data.data);

   }

   public static void read(std_msgs.msg.String data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.data = cdr.read_type_d();	

   }


	public override void Serialize(std_msgs.msg.String data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.String data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.String data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.String src, std_msgs.msg.String target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.String src, std_msgs.msg.String target)
    {
    	Copy(src, target);
    }


}


}