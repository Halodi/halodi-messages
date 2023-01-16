using System.IO;
namespace std_msgs.msg
{

/**
* 
* Topic data type of the struct "MultiArrayLayout" defined in "MultiArrayLayout.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from MultiArrayLayout.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit MultiArrayLayout.idl instead.
*
*/
public class MultiArrayLayoutPubSubType : Halodi.CDR.TopicDataType<MultiArrayLayout>
{
   public override string Name => "std_msgs::msg::dds_::MultiArrayLayout_";


   public static int getCdrSerializedSize(std_msgs.msg.MultiArrayLayout data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(std_msgs.msg.MultiArrayLayout data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.dim.Count; ++i0)
      {
          current_alignment += std_msgs.msg.MultiArrayDimensionPubSubType.getCdrSerializedSize(data.dim[i0], current_alignment);}

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);



      return current_alignment - initial_alignment;
   }

   public static void write(std_msgs.msg.MultiArrayLayout data, Halodi.CDR.CDRSerializer cdr)
   {
      	if(data.dim == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int dim_length = data.dim.Count;
            cdr.write_type_2(dim_length);
            for (int i0 = 0; i0 < dim_length; i0++)
            {
      			std_msgs.msg.MultiArrayDimensionPubSubType.write(data.dim[i0], cdr);	      }
        }
      cdr.write_type_4(data.data_offset);

   }

   public static void read(std_msgs.msg.MultiArrayLayout data, Halodi.CDR.CDRDeserializer cdr)
   {

      int dim_length = cdr.read_type_2();
      data.dim = new System.Collections.Generic.List<std_msgs.msg.MultiArrayDimension>(dim_length);
      for(int i = 0; i < dim_length; i++)
      {
      	std_msgs.msg.MultiArrayDimension new_dim = std_msgs.msg.MultiArrayDimensionPubSubType.Create(); 
      	std_msgs.msg.MultiArrayDimensionPubSubType.read(new_dim, cdr);
      	data.dim.Add(new_dim);	
      	
      }

      	
      data.data_offset=cdr.read_type_4();
      	

   }


	public override void Serialize(std_msgs.msg.MultiArrayLayout data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(std_msgs.msg.MultiArrayLayout data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(std_msgs.msg.MultiArrayLayout data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(std_msgs.msg.MultiArrayLayout src, std_msgs.msg.MultiArrayLayout target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(std_msgs.msg.MultiArrayLayout src, std_msgs.msg.MultiArrayLayout target)
    {
    	Copy(src, target);
    }


}


}