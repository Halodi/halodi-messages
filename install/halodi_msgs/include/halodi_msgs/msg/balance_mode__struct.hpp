// generated from rosidl_generator_cpp/resource/idl__struct.hpp.em
// with input from halodi_msgs:msg/BalanceMode.idl
// generated code does not contain a copyright notice

#ifndef HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_HPP_
#define HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_HPP_

#include <rosidl_generator_cpp/bounded_vector.hpp>
#include <rosidl_generator_cpp/message_initialization.hpp>
#include <algorithm>
#include <array>
#include <memory>
#include <string>
#include <vector>


#ifndef _WIN32
# define DEPRECATED__halodi_msgs__msg__BalanceMode __attribute__((deprecated))
#else
# define DEPRECATED__halodi_msgs__msg__BalanceMode __declspec(deprecated)
#endif

namespace halodi_msgs
{

namespace msg
{

// message struct
template<class ContainerAllocator>
struct BalanceMode_
{
  using Type = BalanceMode_<ContainerAllocator>;

  explicit BalanceMode_(rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->mode = 0l;
    }
  }

  explicit BalanceMode_(const ContainerAllocator & _alloc, rosidl_generator_cpp::MessageInitialization _init = rosidl_generator_cpp::MessageInitialization::ALL)
  {
    (void)_alloc;
    if (rosidl_generator_cpp::MessageInitialization::ALL == _init ||
      rosidl_generator_cpp::MessageInitialization::ZERO == _init)
    {
      this->mode = 0l;
    }
  }

  // field types and members
  using _mode_type =
    int32_t;
  _mode_type mode;

  // setters for named parameter idiom
  Type & set__mode(
    const int32_t & _arg)
  {
    this->mode = _arg;
    return *this;
  }

  // constant declarations
  static constexpr int32_t AUTOMATIC =
    0;
  static constexpr int32_t DRIVING =
    1;
  static constexpr int32_t FOLLOW_ME =
    2;
  static constexpr int32_t FORCE_STATIONARY =
    3;
  static constexpr int32_t DISABLED =
    84;

  // pointer types
  using RawPtr =
    halodi_msgs::msg::BalanceMode_<ContainerAllocator> *;
  using ConstRawPtr =
    const halodi_msgs::msg::BalanceMode_<ContainerAllocator> *;
  using SharedPtr =
    std::shared_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator>>;
  using ConstSharedPtr =
    std::shared_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator> const>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::BalanceMode_<ContainerAllocator>>>
  using UniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator>, Deleter>;

  using UniquePtr = UniquePtrWithDeleter<>;

  template<typename Deleter = std::default_delete<
      halodi_msgs::msg::BalanceMode_<ContainerAllocator>>>
  using ConstUniquePtrWithDeleter =
    std::unique_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator> const, Deleter>;
  using ConstUniquePtr = ConstUniquePtrWithDeleter<>;

  using WeakPtr =
    std::weak_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator>>;
  using ConstWeakPtr =
    std::weak_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator> const>;

  // pointer types similar to ROS 1, use SharedPtr / ConstSharedPtr instead
  // NOTE: Can't use 'using' here because GNU C++ can't parse attributes properly
  typedef DEPRECATED__halodi_msgs__msg__BalanceMode
    std::shared_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator>>
    Ptr;
  typedef DEPRECATED__halodi_msgs__msg__BalanceMode
    std::shared_ptr<halodi_msgs::msg::BalanceMode_<ContainerAllocator> const>
    ConstPtr;

  // comparison operators
  bool operator==(const BalanceMode_ & other) const
  {
    if (this->mode != other.mode) {
      return false;
    }
    return true;
  }
  bool operator!=(const BalanceMode_ & other) const
  {
    return !this->operator==(other);
  }
};  // struct BalanceMode_

// alias to use template instance with default allocator
using BalanceMode =
  halodi_msgs::msg::BalanceMode_<std::allocator<void>>;

// constant definitions
template<typename ContainerAllocator>
constexpr int32_t BalanceMode_<ContainerAllocator>::AUTOMATIC;
template<typename ContainerAllocator>
constexpr int32_t BalanceMode_<ContainerAllocator>::DRIVING;
template<typename ContainerAllocator>
constexpr int32_t BalanceMode_<ContainerAllocator>::FOLLOW_ME;
template<typename ContainerAllocator>
constexpr int32_t BalanceMode_<ContainerAllocator>::FORCE_STATIONARY;
template<typename ContainerAllocator>
constexpr int32_t BalanceMode_<ContainerAllocator>::DISABLED;

}  // namespace msg

}  // namespace halodi_msgs

#endif  // HALODI_MSGS__MSG__BALANCE_MODE__STRUCT_HPP_
