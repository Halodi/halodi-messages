// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/ImuName.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__IMU_NAME__STRUCT_HPP_
#define HALODI_MSGS__MSG__IMU_NAME__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__ImuName __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__ImuName __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct ImuName_
{
  using Type = ImuName_<ContainerAllocator>;

  explicit ImuName_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->imu_id = 0l;
    }
  }

  explicit ImuName_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->imu_id = 0l;
    }
  }

  // field types and members
  using _imu_id_type =
    int32_t;
  _imu_id_type imu_id;

  // setters for named parameter idiom
  Type & set__imu_id(
    const int32_t & _arg)
  {
    this->imu_id = _arg;
    return *this;
  }

  // constant declarations
  static constexpr int32_t pelvis_imu =
    0;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::ImuName_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::ImuName_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ImuName_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::ImuName_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__ImuName
    std::shared_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__ImuName
    std::shared_ptr<halodi_msgs::msg::ImuName_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const ImuName_ & other) const
  {
    if (this->imu_id != other.imu_id) {
      return false;
    }
    return true;
  }
  bool operator!=(const ImuName_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct ImuName_

// alias to use template instance with default allocator
using ImuName =
  halodi_msgs::msg::ImuName_<std::allocator<void>>;

// constant definitions
template<typename ContainerAllocator>
constexpr int32_t ImuName_<ContainerAllocator>::pelvis_imu;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__IMU_NAME__STRUCT_HPP_
