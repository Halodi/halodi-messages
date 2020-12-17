// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/RobotJointCalibrationInfo.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_HPP_
#define HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__RobotJointCalibrationInfo __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__RobotJointCalibrationInfo __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct RobotJointCalibrationInfo_
{
  using Type = RobotJointCalibrationInfo_<ContainerAllocator>;

  explicit RobotJointCalibrationInfo_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->frame_id = "";
      this->transmission_ratio = 0.0;
      this->measurement_offset = 0.0;
    }
  }

  explicit RobotJointCalibrationInfo_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  : frame_id(_alloc)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->frame_id = "";
      this->transmission_ratio = 0.0;
      this->measurement_offset = 0.0;
    }
  }

  // field types and members
  using _frame_id_type =
    std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other>;
  _frame_id_type frame_id;
  using _transmission_ratio_type =
    double;
  _transmission_ratio_type transmission_ratio;
  using _measurement_offset_type =
    double;
  _measurement_offset_type measurement_offset;

  // setters for named parameter idiom
  Type & set__frame_id(
    const std::basic_string<char, std::char_traits<char>, typename ContainerAllocator::template rebind<char>::other> & _arg)
  {
    this->frame_id = _arg;
    return *this;
  }
  Type & set__transmission_ratio(
    const double & _arg)
  {
    this->transmission_ratio = _arg;
    return *this;
  }
  Type & set__measurement_offset(
    const double & _arg)
  {
    this->measurement_offset = _arg;
    return *this;
  }

  // constant declarations

  // pointer types
  using RawPtr =
    halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__RobotJointCalibrationInfo
    std::shared_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__RobotJointCalibrationInfo
    std::shared_ptr<halodi_msgs::msg::RobotJointCalibrationInfo_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const RobotJointCalibrationInfo_ & other) const
  {
    if (this->frame_id != other.frame_id) {
      return false;
    }
    if (this->transmission_ratio != other.transmission_ratio) {
      return false;
    }
    if (this->measurement_offset != other.measurement_offset) {
      return false;
    }
    return true;
  }
  bool operator!=(const RobotJointCalibrationInfo_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct RobotJointCalibrationInfo_

// alias to use template instance with default allocator
using RobotJointCalibrationInfo =
  halodi_msgs::msg::RobotJointCalibrationInfo_<std::allocator<void>>;

// constant definitions

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__ROBOT_JOINT_CALIBRATION_INFO__STRUCT_HPP_
