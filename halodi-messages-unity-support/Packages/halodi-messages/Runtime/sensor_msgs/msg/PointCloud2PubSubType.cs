using System.IO;
namespace sensor_msgs.msg
{

/**
* 
* Topic data type of the struct "PointCloud2" defined in "PointCloud2.idl". Use this class to provide the TopicDataType to a Participant. 
*
* This file was automatically generated from PointCloud2.idl by com.halodi.idl.generator.IDLCSharpGenerator. 
* Do not update this file directly, edit PointCloud2.idl instead.
*
*/
public class PointCloud2PubSubType : Halodi.CDR.TopicDataType<PointCloud2>
{
   public override string Name => "sensor_msgs::msg::dds_::PointCloud2_";


   public static int getCdrSerializedSize(sensor_msgs.msg.PointCloud2 data)
   {
      return getCdrSerializedSize(data, 0);
   }

   public static int getCdrSerializedSize(sensor_msgs.msg.PointCloud2 data, int current_alignment)
   {
      int initial_alignment = current_alignment;

      current_alignment += std_msgs.msg.HeaderPubSubType.getCdrSerializedSize(data.header, current_alignment);

      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      for(int i0 = 0; i0 < data.fields.Count; ++i0)
      {
          current_alignment += sensor_msgs.msg.PointFieldPubSubType.getCdrSerializedSize(data.fields[i0], current_alignment);}

      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);


      current_alignment += 4 + Halodi.CDR.CDRCommon.alignment(current_alignment, 4);
      current_alignment += (data.data.Count * 1) + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);


      current_alignment += 1 + Halodi.CDR.CDRCommon.alignment(current_alignment, 1);



      return current_alignment - initial_alignment;
   }

   public static void write(sensor_msgs.msg.PointCloud2 data, Halodi.CDR.CDRSerializer cdr)
   {
      std_msgs.msg.HeaderPubSubType.write(data.header, cdr);

      cdr.write_type_4(data.height);

      cdr.write_type_4(data.width);

      	if(data.fields == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int fields_length = data.fields.Count;
            cdr.write_type_2(fields_length);
            for (int i0 = 0; i0 < fields_length; i0++)
            {
      			sensor_msgs.msg.PointFieldPubSubType.write(data.fields[i0], cdr);	      }
        }
      cdr.write_type_7(data.is_bigendian);

      cdr.write_type_4(data.point_step);

      cdr.write_type_4(data.row_step);

      	if(data.data == null)
      	{
      		cdr.write_type_2(0);
      	}
      	else
      	{

      	  int data_length = data.data.Count;
            cdr.write_type_2(data_length);
            for (int i0 = 0; i0 < data_length; i0++)
            {
      			cdr.write_type_9(data.data[i0]);
            }
        }
      cdr.write_type_7(data.is_dense);

   }

   public static void read(sensor_msgs.msg.PointCloud2 data, Halodi.CDR.CDRDeserializer cdr)
   {
      data.header = std_msgs.msg.HeaderPubSubType.Create();
      std_msgs.msg.HeaderPubSubType.read(data.header, cdr);
      	
      data.height=cdr.read_type_4();
      	
      data.width=cdr.read_type_4();
      	

      int fields_length = cdr.read_type_2();
      data.fields = new System.Collections.Generic.List<sensor_msgs.msg.PointField>(fields_length);
      for(int i = 0; i < fields_length; i++)
      {
      	sensor_msgs.msg.PointField new_fields = sensor_msgs.msg.PointFieldPubSubType.Create(); 
      	sensor_msgs.msg.PointFieldPubSubType.read(new_fields, cdr);
      	data.fields.Add(new_fields);	
      	
      }

      	
      data.is_bigendian=cdr.read_type_7();
      	
      data.point_step=cdr.read_type_4();
      	
      data.row_step=cdr.read_type_4();
      	

      int data_length = cdr.read_type_2();
      data.data = new System.Collections.Generic.List<byte>(data_length);
      for(int i = 0; i < data_length; i++)
      {
      	data.data.Add(cdr.read_type_9());
      	
      	
      }

      	
      data.is_dense=cdr.read_type_7();
      	

   }


	public override void Serialize(sensor_msgs.msg.PointCloud2 data, Halodi.CDR.CDRSerializer cdr)
   	{
   		write(data, cdr);	
   	}

	public override void Deserialize(sensor_msgs.msg.PointCloud2 data, Halodi.CDR.CDRDeserializer cdr)
   	{
   		read(data, cdr);	
   	}
   	
   	public override int GetSize(sensor_msgs.msg.PointCloud2 data)
   	{
   		return getCdrSerializedSize(data);
   	}

    public static void Copy(sensor_msgs.msg.PointCloud2 src, sensor_msgs.msg.PointCloud2 target)
    {
        target.Set(src);
    }
    
    public override void CopyTo(sensor_msgs.msg.PointCloud2 src, sensor_msgs.msg.PointCloud2 target)
    {
    	Copy(src, target);
    }


}


}